using System.Collections.Generic;

namespace Framework.AssetLibrary.Globalization
{
    public class Country
    {  

        /// <summary>
        /// Gets or sets the country code two letter.
        /// </summary>
        /// <value>The country code two letter.</value>
        public string CountryCodeTwoLetter { get; internal set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>The name of the country.</value>
        public string CountryName { get; internal set; }

        /// <summary>
        /// Gets or sets the phone code.
        /// </summary>
        /// <value>The phone code.</value>
        public string PhoneCode { get; internal set; }

        /// <summary>
        /// Gets or sets the continent.
        /// </summary>
        /// <value>The continent.</value>
        public string Continent { get; internal set; }

        /// <summary>
        /// Gets or sets the capital.
        /// </summary>
        /// <value>The capital.</value>
        public string Capital { get; internal set; }

        /// <summary>
        /// Gets or sets the olson for capital.
        /// </summary>
        /// <value>The olson for capital.</value>
        public string OlsonForCapital { get; internal set; }

        /// <summary>
        /// Gets or sets the areakm2.
        /// </summary>
        /// <value>The areakm2.</value>
        public string Areakm2 { get; internal set; }

        /// <summary>
        /// Gets or sets the flag.
        /// </summary>
        /// <value>The flag.</value>
        public string Flag { get; internal set; }       
        
        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <value>The languages.</value>
        public IEnumerable<Language> Languages { get; internal set; }

        /// <summary>
        /// Gets the time zones.
        /// </summary>
        /// <value>The time zones.</value>
        public IEnumerable<CountryTimeZone> TimeZones { get; internal set; }

        /// <summary>
        /// Gets the cultures.
        /// </summary>
        /// <value>The cultures.</value>
        public IEnumerable<Culture> Cultures { get; internal set; }
    }
}
