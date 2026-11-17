using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData
{
    public class SensorSummaryDataChunkDTO
    {
        public string ChunkId { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<SensorSummaryDataDTO> ChunkData { get; set; }
    }
}
