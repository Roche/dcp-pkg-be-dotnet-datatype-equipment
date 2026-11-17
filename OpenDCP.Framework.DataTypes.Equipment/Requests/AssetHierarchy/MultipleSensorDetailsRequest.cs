using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy
{
    [Obsolete]
    public class MultipleSensorDetailsRequest
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> SensorsWebIds { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
    }
}
