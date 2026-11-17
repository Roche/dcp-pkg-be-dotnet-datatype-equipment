using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;
using OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.SensorData
{
    public class SensorDataWithBatchContextResponse : DatasourceResponse
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<SensorDataDTO> SensorData { get; set; } = new List<SensorDataDTO>();
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<BatchDataDTO> BatchData { get; set; } = new List<BatchDataDTO>();
    }
}

