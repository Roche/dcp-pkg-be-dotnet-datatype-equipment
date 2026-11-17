using OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy;
using OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.Equipment.Interfaces
{
    public interface IAssetHierarchyDataSource
    {
        Task<SensorResponse> GetSingleSensorAsync(string webId, CancellationToken cancellationToken = default);
        Task<SensorListResponse> GetMultipleSensorsAsync(SensorQueryDTO model, CancellationToken cancellationToken = default);
        Task<SensorListResponse> GetDeviceSensorsAsync(string webId, string groupName = null, CancellationToken cancellationToken = default);
        Task<GroupedSensorListResponse> GetGroupedDeviceSensorsAsync(string webId, CancellationToken cancellationToken = default);
        Task<SensorDeviceInfoResponse> GetSensorsDeviceAsync(List<string> webId, CancellationToken cancellationToken = default);
        Task<DeviceResponse> GetSingleDeviceAsync(string webId, CancellationToken cancellationToken = default);
        Task<DeviceListResponse> SearchDevicesAsync(DeviceQueryDTO model, CancellationToken cancellationToken = default);
        Task<DeviceListResponse> GetMultipleDevicesAsync(MultiWebIdQueryDTO model, CancellationToken cancellationToken = default);
        Task<DatasourceUnitResponse> GetUnitsOfMeasureAsync(CancellationToken cancellationToken = default);
        Task<ElementMetaDataResponse> GetElementMetaDataAsync(string webId, CancellationToken cancellationToken = default);
        Task<GlobalFilterListResponse> GetGlobalFilterAsync(string link, CancellationToken cancellationToken = default);
        Task<GlobalFilterResponse> GetGlobalFilterElementAsync(string webId, CancellationToken cancellationToken = default);
        Task<GlobalFilterListResponse> GetGlobalFilterBackwardsAsync(string webId, CancellationToken cancellationToken = default);
        Task<GlobalFilterResponse> GetPreviousGlobalFilterAsync(string link, CancellationToken cancellationToken = default);
        Task<GlobalFilterResponse> GetGlobalFilterElementAsync(GlobalFilterElementByPathRequest model, CancellationToken cancellationToken = default);
        Task<GlobalFilterListResponse> SearchGlobalFilterElementsAsync(GlobalFilterElementQueryDTO model, CancellationToken cancellationToken = default);
        Task<GlobalFilterLevelResponse> GetFullHierarchyLevelsAsync(string webId, CancellationToken cancellationToken = default);
        [Obsolete]
        Task<string> GetPreviousGlobalFilterWebIdAsync(string webId, CancellationToken cancellationToken = default);
    }
}
