using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.EventFrameContext
{
    public class EventFrameResponse : DatasourceResponse
    {
        public EventFrameDTO Eventframe { get; set; }
    }
}
