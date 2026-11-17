using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    [Obsolete]
    public class DeviceEventFrameAttributeRequest
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public string DeviceWebId { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
    }
}
