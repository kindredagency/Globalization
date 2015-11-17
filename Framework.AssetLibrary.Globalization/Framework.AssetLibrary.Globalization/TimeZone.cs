using System;

namespace Framework.AssetLibrary.Globalization
{
    public class TimeZone
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

        /// <summary>
        /// Gets or sets the UTC off set.
        /// </summary>
        /// <value>The UTC off set.</value>
        public TimeSpan? UtcOffSet
        {
            get
            {
                if (!string.IsNullOrEmpty(Utc))
                {
                    string[] utcParts = Utc.Substring(1, Utc.Length - 2).Split(':');

                    char sign = Utc[0];

                    return sign == '+' ? new TimeSpan(+Convert.ToInt32(utcParts[0]), Convert.ToInt32(utcParts[1]), 0)
                        : sign == '-' ? new TimeSpan(-Convert.ToInt32(utcParts[0]), Convert.ToInt32(utcParts[1]), 0)
                        : new TimeSpan(Convert.ToInt32(utcParts[0]), Convert.ToInt32(utcParts[1]), 0);
                }

                return null;
            }
        }
    }
}
