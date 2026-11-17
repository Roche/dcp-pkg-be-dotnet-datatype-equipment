using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.EventFrameContext
{
    public class EventframeListResponse : DatasourceResponse
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<EventFrameDTO> Eventframes { get; set; } = new List<EventFrameDTO>();
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<EventFrameAttributeDTO> Attributes { get; set; } = new List<EventFrameAttributeDTO>();
    }
}
