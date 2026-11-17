using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class InterpolatedDataChunksRequest
    {
        public List<InterpolatedDataRequestChunk> Chunks { get; set; }
    }
}
