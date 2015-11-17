using System;

namespace Framework.AssetLibrary.Globalization
{
    public class CountryTimeZone
    {
        /// <summary>
        /// Gets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        public TimeZone TimeZone { get; internal set; }

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

        /// <summary>
        /// Gets the local date time.
        /// </summary>
        /// <value>The local date time.</value>
        public DateTimeOffset? LocalDateTime
        {
            get
            {
                var utcOffSet = new DateTimeOffset(DateTime.UtcNow, TimeSpan.Zero);
                return TimeZone.UtcOffSet.HasValue ? (DateTimeOffset?)utcOffSet.ToOffset(TimeZone.UtcOffSet.Value) : null;
            }
        }

        /// <summary>
        /// Gets the information.
        /// </summary>
        /// <value>The information.</value>
        public TimeZoneInfo Info
        {
            get
            {
                if (TimeZone.MicrosoftZoneName == null) return null;

                try
                {
                    var msTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZone.MicrosoftZoneName);
                    return TimeZone.UtcOffSet.HasValue ? TimeZoneInfo.CreateCustomTimeZone(TimeZone.ZoneName, TimeZone.UtcOffSet.Value, TimeZone.ZoneName, TimeZone.ZoneName, msTimeZone.DaylightName, msTimeZone.GetAdjustmentRules(), msTimeZone.SupportsDaylightSavingTime) : null;
                }
                catch
                {
                    return TimeZone.UtcOffSet.HasValue ? TimeZoneInfo.CreateCustomTimeZone(TimeZone.ZoneName, TimeZone.UtcOffSet.Value, TimeZone.ZoneName, TimeZone.ZoneName) : null;
                }
            }
        }

    }
}
