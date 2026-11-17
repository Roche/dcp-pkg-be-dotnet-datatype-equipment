using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy
{
    [Obsolete]
    public class DatasourceUnitsRequest
    {
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
    }
}
