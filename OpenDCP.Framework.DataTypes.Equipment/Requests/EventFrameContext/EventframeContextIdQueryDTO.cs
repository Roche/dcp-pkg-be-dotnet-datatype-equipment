using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    public class EventframeContextIdQueryDTO
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> Id { get; set; } = new List<string>();
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; } = new List<string>();
    }
}
