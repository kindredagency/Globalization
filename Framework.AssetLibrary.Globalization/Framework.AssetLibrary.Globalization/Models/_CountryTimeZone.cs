namespace Framework.AssetLibrary.Globalization.Models
{
    /// <summary>
    /// Class _CountryTimeZone.
    /// </summary>
    public class _CountryTimeZone
    {
        /// <summary>
        /// Gets or sets the country code two letter.
        /// </summary>
        /// <value>The country code two letter.</value>
        public string CountryCodeTwoLetter { get; set; }

        /// <summary>
        /// Gets or sets the name of the zone.
        /// </summary>
        /// <value>The name of the zone.</value>
        public string ZoneName { get; set; }

        /// <summary>
        /// Gets or sets the olson.
        /// </summary>
        /// <value>The olson.</value>
        public string Olson { get; set; }

        /// <summary>
        /// Gets or sets the DST.
        /// </summary>
        /// <value>The DST.</value>
        public string Dst { get; set; }       
    }
}
