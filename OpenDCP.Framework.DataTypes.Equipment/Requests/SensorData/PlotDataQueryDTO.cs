using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class PlotDataQueryDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Intervals { get; set; } = 200;
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; } = new List<string>();
        public DateTime? BatchStartTime { get; set; } = null;
    }
}
