using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.AssetLibrary.Globalization
{ 
    public static class GlobalizationFactory
    {
        public static IEnumerable<TimeZone> GetTimeZones()
        {
            return GlobalizationRepository.GetTimeZones().Select(c => new TimeZone { ZoneName = c.ZoneName, ZoneCode = c.ZoneCode, MicrosoftZoneName = c.MicrosoftZoneName, MicrosoftName = c.MicrosoftName, Utc = c.Utc });
        }

        public static TimeZone GetTimeZone(string zoneName)
        {
            var timezone = GetTimeZones().FirstOrDefault(c => c.ZoneName == zoneName);
            return timezone;
        }

        public static IEnumerable<Language> GetLanguages()
        {
            return GlobalizationRepository.GetLanguages().Select(c => new Language { LanguageName = c.LanguageName, LanguageCodeTwoLetter = c.LanguageCodeTwoLetter });
        }

        public static Language GetLanguage(string languageCodeTwoLetter)
        {
            var language = GetLanguages().FirstOrDefault(c => c.LanguageCodeTwoLetter == languageCodeTwoLetter);
            return language;
        }

        public static IEnumerable<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();

            var _Countries = GlobalizationRepository.GetCountries();
            var _CountryDetails = GlobalizationRepository.GetCountryDetails();
            var _CountryTimeZones = GlobalizationRepository.GetCountryTimeZones();
            var _CountryLanguages = GlobalizationRepository.GetCountryLanguages();

            foreach (var _Country in _Countries)
            {
                var _CountryDetail = _CountryDetails.FirstOrDefault(c => c.CountryCodeTwoLetter == _Country.CountryCodeTwoLetter);

                Country country = new Country
                {
                    CountryCodeTwoLetter = _Country.CountryCodeTwoLetter,
                    CountryName = _Country.CountryName
                };

                if (_CountryDetail != null)
                {
                    country.PhoneCode = _CountryDetail.PhoneCode;
                    country.Continent = _CountryDetail.Continent;
                    country.Capital = _CountryDetail.Capital;
                    country.OlsonForCapital = _CountryDetail.OlsonForCapital;
                    country.Areakm2 = _CountryDetail.Areakm2;
                }

                country.Languages = _CountryLanguages.Where(c => c.CountryCodeTwoLetter == _Country.CountryCodeTwoLetter).Select(c => GetLanguage(c.LanguageCodeTwoLetter));
                country.TimeZones = _CountryTimeZones.Where(c => c.CountryCodeTwoLetter == _Country.CountryCodeTwoLetter).Select(c => new CountryTimeZone { TimeZone = GetTimeZone(c.ZoneName), Dst = c.Dst, Olson = c.Olson });

                byte[] flag = Utility.LoadResourceFile(_Country.CountryCodeTwoLetter.ToLower() + ".png");

                if (flag != null)
                {
                    country.Flag = $"data:image/png;base64,{Convert.ToBase64String(flag)}";
                }

                country.Cultures = _CountryLanguages.Where(c => c.CountryCodeTwoLetter == _Country.CountryCodeTwoLetter).Select(c =>
                new Culture
                {
                    Language = GetLanguage(c.LanguageCodeTwoLetter),
                    Country = country
                });

                countries.Add(country);
            }

            return countries.AsEnumerable();
        }

        public static Country GetCountry(string countryCodeTwoLetter)
        {
            var country = GetCountries().FirstOrDefault(c => c.CountryCodeTwoLetter == countryCodeTwoLetter);
            return country;
        }

        public static IEnumerable<Culture> GetCultures()
        {
            return GetCountries().SelectMany(c => c.Cultures).GroupBy(c => c.CultureCode).Select(c => c.First());
        }

        public static Culture GetCulture(string cultureCode)
        {
            return GetCultures().FirstOrDefault(c => c.CultureCode == cultureCode);
        }

    }
}
