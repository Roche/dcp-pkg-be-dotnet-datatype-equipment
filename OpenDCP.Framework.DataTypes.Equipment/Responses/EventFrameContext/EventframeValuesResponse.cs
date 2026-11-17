using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.EventFrameContext
{
    public class EventframeValuesResponse : DatasourceResponse
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<EventFrameValueDTO> Values { get; set; } = new List<EventFrameValueDTO>();
    }
}
