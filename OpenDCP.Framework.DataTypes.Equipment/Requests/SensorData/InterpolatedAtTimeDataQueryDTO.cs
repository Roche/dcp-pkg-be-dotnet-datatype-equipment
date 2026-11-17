using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class InterpolatedAtTimeDataQueryDTO
    {
        public List<DateTime> Time { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; }
    }
}
