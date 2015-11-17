using Framework.AssetLibrary.Caching;
using Framework.AssetLibrary.Globalization.Models;
using System.Collections.Generic;
using System.Linq;

namespace Framework.AssetLibrary.Globalization
{
    public static class GlobalizationRepository
    {
        public static List<_Country> GetCountries()
        {
            string cacheKey = "Framework.AssetLibrary.Globalization::GetCountries";

            ICacheContext cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(cacheKey))
            {
                List<_Country> result = Utility.LoadDataFile("Country.xml").Element("countries")?.Elements("country")
                                        .Select(c => new _Country
                                        {
                                            CountryCodeTwoLetter = c.Attribute("countrycodetwoletter").Value,
                                            CountryName = c.Attribute("countryname").Value
                                        }).ToList();

                cacheContext.Add(cacheKey, result);

                return result;
            }

            return cacheContext.Get<List<_Country>>(cacheKey);
        }

        public static List<_CountryDetail> GetCountryDetails()
        {
            string cacheKey = "Framework.AssetLibrary.Globalization::GetCountryDetails";

            ICacheContext cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(cacheKey))
            {
                List<_CountryDetail> result = Utility.LoadDataFile("CountryDetail.xml").Element("countries")?.Elements("country")
                                        .Select(c => new _CountryDetail
                                        {
                                            CountryCodeTwoLetter = c.Attribute("countrycodetwoletter").Value,
                                            PhoneCode = c.Attribute("phonecode").Value,
                                            Continent = c.Attribute("continent").Value,
                                            Capital = c.Attribute("capital").Value,
                                            OlsonForCapital = c.Attribute("olsonforcapital").Value,
                                            Areakm2 = c.Attribute("areakm2").Value,
                                        }).ToList();

                cacheContext.Add(cacheKey, result);

                return result;
            }

            return cacheContext.Get<List<_CountryDetail>>(cacheKey);
        }

        public static List<_CountryTimeZone> GetCountryTimeZones()
        {
            string cacheKey = "Framework.AssetLibrary.Globalization::GetCountryTimeZones";

            ICacheContext cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(cacheKey))
            {
                List<_CountryTimeZone> result = Utility.LoadDataFile("CountryTimeZone.xml").Element("countrytimezones")?.Elements("countrytimezone")
                                               .Select(c => new _CountryTimeZone
                                               {
                                                   CountryCodeTwoLetter = c.Attribute("countrycodetwoletter").Value,
                                                   ZoneName = c.Attribute("zonename").Value,
                                                   Olson = c.Attribute("olson").Value,
                                                   Dst = c.Attribute("dst").Value
                                               }).ToList();

                cacheContext.Add(cacheKey, result);

                return result;
            }

            return cacheContext.Get<List<_CountryTimeZone>>(cacheKey);
        }

        public static List<_CountryLanguage> GetCountryLanguages()
        {
            string cacheKey = "Framework.AssetLibrary.Globalization::GetCountryLanguages";

            ICacheContext cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(cacheKey))
            {
                List<_CountryLanguage> result = Utility.LoadDataFile("CountryLanguage.xml").Element("countrylanguages")?.Elements("countrylanguage")
                                                .Select(c => new _CountryLanguage
                                                {
                                                    CountryCodeTwoLetter = c.Attribute("countrycodetwoletter").Value,
                                                    LanguageCodeTwoLetter = c.Attribute("languagecodetwoletter").Value
                                                }).ToList();

                cacheContext.Add(cacheKey, result);

                return result;
            }

            return cacheContext.Get<List<_CountryLanguage>>(cacheKey);
        }

        public static List<_Language> GetLanguages()
        {
            string cacheKey = "Framework.AssetLibrary.Globalization::GetLanguages";

            ICacheContext cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(cacheKey))
            {
                List<_Language> result = Utility.LoadDataFile("Language.xml").Element("languages")?.Elements("language")
                                                .Select(c => new _Language
                                                {
                                                    LanguageCodeThreeLetter = c.Attribute("languagecodethreeletter").Value,
                                                    LanguageCodeTwoLetter = c.Attribute("languagecodetwoletter").Value,
                                                    LanguageName = c.Attribute("languagename").Value
                                                }).ToList();

                cacheContext.Add(cacheKey, result);

                return result;
            }

            return cacheContext.Get<List<_Language>>(cacheKey);
        }

        public static List<_TimeZone> GetTimeZones()
        {
            string cacheKey = "Framework.AssetLibrary.Globalization::GetTimeZones";

            ICacheContext cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(cacheKey))
            {
                List<_TimeZone> result = Utility.LoadDataFile("TimeZone.xml").Element("timezones")?.Elements("timezone")
                                        .Select(c => new _TimeZone
                                        {
                                            ZoneName = c.Attribute("zonename").Value,
                                            ZoneCode = c.Attribute("zonecode").Value,
                                            MicrosoftZoneName = c.Attribute("microsoftzonename").Value,
                                            MicrosoftName = c.Attribute("microsoftname").Value,
                                            Utc = c.Attribute("utc").Value
                                        }).ToList();

                cacheContext.Add(cacheKey, result);

                return result;
            }

            return cacheContext.Get<List<_TimeZone>>(cacheKey);
        }                 

    }
}
