using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy
{
    public class GlobalFilterResponse : DatasourceResponse
    {
        public GlobalFilterElementDTO Element { get; set; }
    }
}
