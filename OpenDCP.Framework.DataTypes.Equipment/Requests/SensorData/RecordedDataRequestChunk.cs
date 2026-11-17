
using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class RecordedDataRequestChunk
    {
        public string ChunkId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; }
    }
}
