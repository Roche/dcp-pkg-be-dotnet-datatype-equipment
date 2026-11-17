using OpenDCP.Framework.DataTypes.Equipment.Requests.SensorData;
using OpenDCP.Framework.DataTypes.Equipment.Responses.SensorData;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.Equipment.Interfaces
{
    public interface ISensorTelemetryDataSource
    {
        Task<SensorDataResponse> GetInterpolatedDataAsync(InterpolatedDataQueryDTO model, CancellationToken cancellationToken = default);
        Task<SensorDataResponse> GetRecordedDataAsync(RecordedDataQueryDTO model, CancellationToken cancellationToken = default);
        Task<SensorDataResponse> GetPlotDataAsync(PlotDataQueryDTO model, CancellationToken cancellationToken = default);
        Task<SensorDataResponse> GetInterpolatedDataAtTimesAsync(InterpolatedAtTimeDataQueryDTO model, CancellationToken cancellationToken = default);
        Task<SensorDataResponse> GetRecordedDataAtTimesAsync(RecordedAtTimeDataQueryDTO model, CancellationToken cancellationToken = default);
        Task<SensorDataSummaryStatisticsChunksResponse> GetSummaryDataChunksAsync(SummaryDataChunksRequest model, CancellationToken cancellationToken = default);
        Task<SensorDataChunksResponse> GetRecordedDataChunksAsync(RecordedDataChunksRequest model, CancellationToken cancellationToken = default);
        Task<SensorDataChunksResponse> GetInterpolatedDataChunksAsync(InterpolatedDataChunksRequest model, CancellationToken cancellationToken = default);
    }
}