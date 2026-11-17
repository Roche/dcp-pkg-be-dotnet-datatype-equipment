using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents a batch or event frame context for a device, including its time boundaries.
    /// </summary>
    /// <remarks>
    /// The <see cref="BatchContextDTO"/> is typically used to track production batches,
    /// process events, or time-bound operations associated with a specific device.
    /// </remarks>
    public class BatchContextDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the batch or event frame.
        /// </summary>
        /// <example>
        /// "Batch_2025_001"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the start time of the batch in ISO 8601 format.
        /// </summary>
        /// <example>
        /// "2025-10-20T08:00:00Z"
        /// </example>
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the batch in ISO 8601 format.
        /// </summary>
        /// <example>
        /// "2025-10-20T16:00:00Z"
        /// </example>
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the Web ID of the device associated with this batch.
        /// </summary>
        /// <example>
        /// "DeviceWebId_123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string DeviceWebId { get; set; }
    }
}
