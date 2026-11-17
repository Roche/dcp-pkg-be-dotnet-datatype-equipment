using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    [Obsolete]
    public class RecordedAtTimesRequest
    {
        public List<string> SensorsWebIds { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
        public List<string> Times { get; set; }
        public string RetrievalMode { get; set; }
    }
}
