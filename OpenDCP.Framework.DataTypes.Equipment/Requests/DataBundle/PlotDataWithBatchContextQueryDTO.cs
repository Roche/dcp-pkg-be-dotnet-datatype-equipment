using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.DataBundle
{
    public class PlotDataWithBatchContextQueryDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Intervals { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> DeviceWebId { get; set; }
    }
}
