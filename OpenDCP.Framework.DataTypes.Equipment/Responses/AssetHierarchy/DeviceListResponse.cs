using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy
{
    public class DeviceListResponse : DatasourceResponse
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<DeviceDTO> Devices { get; set; } = new List<DeviceDTO>();
    }
}
