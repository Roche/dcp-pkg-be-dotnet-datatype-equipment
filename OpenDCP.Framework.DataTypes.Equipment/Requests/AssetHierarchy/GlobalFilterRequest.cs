using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy
{
    [Obsolete]
    public class GlobalFilterRequest
    {
        public string Link { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public string WebId { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
    }
}
