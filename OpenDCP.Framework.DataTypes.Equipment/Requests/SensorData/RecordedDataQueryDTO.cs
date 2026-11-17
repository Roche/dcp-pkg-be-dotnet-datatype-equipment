using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Equipment.Constants;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class RecordedDataQueryDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MaxCount { get; set; } = 1000;
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; }
        public string FilterExpression { get; set; } = null;
        public bool IncludeFilteredValues { get; set; } = true;
        public bool SynchronizeTimestamps { get; set; } = false;
        public BoundaryType BoundaryType { get; set; } = BoundaryType.Inside;
    }
}
