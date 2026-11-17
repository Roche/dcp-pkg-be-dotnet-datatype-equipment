using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Equipment.Constants;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData
{
    public class RecordedAtTimeDataQueryDTO
    {
        public RetrievalMode RetrievalMode { get; set; } = RetrievalMode.AtOrBefore;
        public List<DateTime> Time { get; set; }
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; }
    }
}
