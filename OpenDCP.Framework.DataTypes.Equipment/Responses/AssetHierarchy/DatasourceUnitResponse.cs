using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy
{
    public class DatasourceUnitResponse : DatasourceResponse
    {
        public List<DatasourceUnit> Units { get; set; } = new List<DatasourceUnit>();
    }
}
