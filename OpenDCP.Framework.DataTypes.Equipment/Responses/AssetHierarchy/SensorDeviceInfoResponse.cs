using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy
{
    public class SensorDeviceInfoResponse: DatasourceResponse
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<SensorDeviceInfoDTO> SensorDeviceInfo {  get; set; } = new List<SensorDeviceInfoDTO>();
    }
}
