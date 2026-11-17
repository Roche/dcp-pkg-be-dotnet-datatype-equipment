
using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Equipment.Constants;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class InterpolatedDataRequestChunk
    {
        public string ChunkId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Interval { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; }
        public BoundaryType BoundaryType { get; set; } = BoundaryType.Inside;
    }
}
