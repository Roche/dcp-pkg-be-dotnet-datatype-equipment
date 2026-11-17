using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    [Obsolete]
    public class PlotDataRequest
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Intervals { get; set; }
        public List<string> SensorsWebIds { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
        public string BatchStartTime { get; set; }
    }
}
