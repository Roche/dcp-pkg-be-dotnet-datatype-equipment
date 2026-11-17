using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents the association between a sensor and its parent device.
    /// </summary>
    /// <remarks>
    /// The <see cref="SensorDeviceInfoDTO"/> is used to map a sensor to the device it belongs to,
    /// typically for hierarchy navigation, data retrieval, or device-level reporting.
    /// </remarks>
    public class SensorDeviceInfoDTO
    {
        /// <summary>
        /// Gets or sets the unique Web ID of the sensor.
        /// </summary>
        /// <example>
        /// "AbCdEfGhIjKlMnOpQrStUvWxYz123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string WebId { get; set; }

        /// <summary>
        /// Represents a device within the asset hierarchy, including its identification,
        /// descriptive information, and associated categories.
        /// </summary>
        /// <remarks>
        public DeviceDTO Device { get; set; }
    }
}
