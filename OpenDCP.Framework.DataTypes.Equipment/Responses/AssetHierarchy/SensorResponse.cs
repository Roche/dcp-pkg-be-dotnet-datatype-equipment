using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy
{
    public class SensorResponse : DatasourceResponse
    {
        public SensorDTO Sensor { get; set; }
    }
}
