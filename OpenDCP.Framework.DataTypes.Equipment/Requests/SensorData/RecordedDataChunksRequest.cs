using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class RecordedDataChunksRequest
    {
        public List<RecordedDataRequestChunk> Chunks { get; set; }
    }
}
