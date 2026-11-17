using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.SensorData
{
    public class SensorDataResponse : DatasourceResponse
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<SensorDataDTO> Data { get; set; } = new List<SensorDataDTO>();
    }
}
