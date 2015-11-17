namespace Framework.AssetLibrary.Globalization.Models
{
    public class _TimeZone
    {
        /// <summary>
        /// Gets or sets the name of the zone.
        /// </summary>
        /// <value>The name of the zone.</value>
        public string ZoneName { get; set; }

        /// <summary>
        /// Gets or sets the zone code.
        /// </summary>
        /// <value>The zone code.</value>
        public string ZoneCode { get; set; }

        /// <summary>
        /// Gets or sets the microsoft time zone.
        /// </summary>
        /// <value>The microsoft time zone.</value>
        public string MicrosoftZoneName { get; set; }

        /// <summary>
        /// Gets or sets the name of the microsoft.
        /// </summary>
        /// <value>The name of the microsoft.</value>
        public string MicrosoftName { get; set; }

        /// <summary>
        /// Gets or sets the UTC.
        /// </summary>
        /// <value>The UTC.</value>
        public string Utc { get; set; }
    }
}
