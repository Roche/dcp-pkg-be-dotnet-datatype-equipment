using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    [Obsolete]
    public class EventFrameAttributesValuesRequest
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public string EventFrameWebId { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
    }
}
