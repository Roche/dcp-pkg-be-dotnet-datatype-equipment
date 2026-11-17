using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    [Obsolete]
    public class SummaryDataRequest
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<string> SummaryTypes { get; set; }
        public List<string> SensorsWebIds { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
    }
}
