using OpenDCP.Framework.Configuration.Model.Interfaces;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;
using OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext;
using OpenDCP.Framework.DataTypes.Equipment.Responses.EventFrameContext;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.Equipment.Interfaces
{
    public interface IEventframeContextDataSource : IEventTranslation
    {
        Task<BatchContextListResponse> SearchBatchContextByTimeAsync(BatchContextTimeQueryDTO model, CancellationToken cancellationToken = default);
        Task<EventframeListResponse> SearchEventframeContextByTimeAsync(EventframeContextTimeQueryDTO model, CancellationToken cancellationToken = default);
        Task<EventframeListResponse> SearchEventframeContextByIdAsync(EventframeContextIdQueryDTO model, CancellationToken cancellationToken = default);
        Task<EventFrameResponse> GetEventframeAsync(string id, CancellationToken cancellationToken = default);
        Task<EventframeValuesResponse> GetEventframeValuesAsync(string id, CancellationToken cancellationToken = default);
        Task<EventframeAttributesResponse> GetEventframeAttributesAsync(string deviceWebId, CancellationToken cancellationToken = default);
        Task<EventframeTemplateListResponse> GetEventframeTemplatesAsync(List<string> webIds, CancellationToken cancellationToken = default);
        Task<EventframeAttributesResponse> GetTemplateDetailsAsync(List<string> webIds, CancellationToken cancellationToken = default);
        string ExtractDisplayEventId(List<EventFrameValueDTO> values, string id);
        List<string> EventFrameId2WebId(List<string> id);
        List<string> WebId2EventFrameId(List<string> webId);
        string EventFrameId2WebId(string id);
        string WebId2EventFrameId(string webId);
    }
}