using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Equipment.Constants;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    public class EventframeContextTimeQueryDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EventframeSearchMode SearchMode { get; set; } = EventframeSearchMode.Overlapped;
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> DeviceWebId { get; set; }
        public bool IncludeAttributeSettings { get; set; } = false;
        public AttributeFilterGroupDTO Filter { get; set; } = new AttributeFilterGroupDTO();
    }
}
