using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    public class EventframeTemplateQueryDTO
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebId { get; set; } = new List<string>();
        public List<string> Name { get; set; } = new List<string>();
    }
}
