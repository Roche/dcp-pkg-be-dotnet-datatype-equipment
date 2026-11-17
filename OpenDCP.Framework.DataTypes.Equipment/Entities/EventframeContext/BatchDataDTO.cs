using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents batch data for a device, including associated event frames.
    /// </summary>
    /// <remarks>
    /// The <see cref="BatchDataDTO"/> is used to group event frames by device,
    /// allowing clients to retrieve or process all batches associated with a particular device.
    /// </remarks>
    public class BatchDataDTO
    {
        /// <summary>
        /// Gets or sets the Web ID of the device associated with these batches.
        /// </summary>
        /// <example>
        /// "DeviceWebId_123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string DeviceWebId { get; set; }

        /// <summary>
        /// Gets or sets the collection of event frames (batches) for the device.
        /// </summary>
        /// <remarks>
        /// Each event frame is represented by a <see cref="BatchContextDTO"/> object.
        /// </remarks>
        /// <example>
        /// [
        ///   { Id = "Batch_001", StartTime = "2025-10-20T08:00:00Z", EndTime = "2025-10-20T16:00:00Z" },
        ///   { Id = "Batch_002", StartTime = "2025-10-21T08:00:00Z", EndTime = "2025-10-21T16:00:00Z" }
        /// ]
        /// </example>
        public List<BatchContextDTO> EventFrames { get; set; }
    }
}
