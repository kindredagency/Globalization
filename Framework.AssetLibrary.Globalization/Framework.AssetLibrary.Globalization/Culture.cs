using System.Globalization;

namespace Framework.AssetLibrary.Globalization
{
    public class Culture
    {
        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        public Country Country { get; internal set; }

        /// <summary>
        /// Gets the language.
        /// </summary>
        /// <value>The language.</value>
        public Language Language { get; internal set; }

        /// <summary>
        /// Gets the region information.
        /// </summary>
        /// <value>The region information.</value>
        internal RegionInfo _RegionInfo => new RegionInfo(CultureInfo.Name);


        /// <summary>
        /// Gets the culture information.
        /// </summary>
        /// <value>The culture information.</value>
        internal CultureInfo CultureInfo => new CultureInfo(Language.LanguageCodeTwoLetter + "-" + Country.CountryCodeTwoLetter);


        /// <summary>
        /// Gets or sets the name of the country english.
        /// </summary>
        /// <value>The name of the country english.</value>
        public string CountryEnglishName => _RegionInfo?.EnglishName;

        /// <summary>
        /// Gets or sets the name of the country native.
        /// </summary>
        /// <value>The name of the country native.</value>
        public string CountryNativeName => _RegionInfo?.NativeName;

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        public string CurrencyCode => _RegionInfo?.ISOCurrencySymbol;

        /// <summary>
        /// Gets or sets the name of the currency english.
        /// </summary>
        /// <value>The name of the currency english.</value>
        public string CurrencyEnglishName => _RegionInfo?.CurrencyEnglishName;

        /// <summary>
        /// Gets or sets the name of the currency native.
        /// </summary>
        /// <value>The name of the currency native.</value>
        public string CurrencyNativeName => _RegionInfo?.CurrencyNativeName;

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        /// <value>The currency symbol.</value>
        public string CurrencySymbol => _RegionInfo?.CurrencySymbol;

        /// <summary>
        /// Gets or sets the culture code.
        /// </summary>
        /// <value>The culture code.</value>
        public string CultureCode => CultureInfo.Name;

        /// <summary>
        /// Gets or sets the name of the culture english.
        /// </summary>
        /// <value>The name of the culture english.</value>
        public string CultureEnglishName => CultureInfo.EnglishName;

        /// <summary>
        /// Gets or sets the name of the culture native.
        /// </summary>
        /// <value>The name of the culture native.</value>
        public string CultureNativeName => CultureInfo.NativeName;

        /// <summary>
        /// Gets the number format.
        /// </summary>
        /// <value>The number format.</value>
        public NumberFormatInfo NumberFormat => CultureInfo.NumberFormat;

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>The date time format.</value>
        public DateTimeFormatInfo DateTimeFormat => CultureInfo.DateTimeFormat;

        /// <summary>
        /// Gets the text format.
        /// </summary>
        /// <value>The text format.</value>
        public TextInfo TextFormat => CultureInfo.TextInfo;

        /// <summary>
        /// Gets the calendar.
        /// </summary>
        /// <value>The calendar.</value>
        public Calendar Calendar => CultureInfo.Calendar;

        /// <summary>
        /// Gets a value indicating whether this instance is un known.
        /// </summary>
        /// <value><c>true</c> if this instance is un known; otherwise, <c>false</c>.</value>
        public bool IsUnKnown => CultureInfo.Name.Contains("Unknown Locale");
    }
}
