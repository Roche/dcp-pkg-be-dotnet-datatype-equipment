using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents an event frame, including its time boundaries, reference, and associated values.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventFrameDTO"/> is typically used to capture a specific period or event 
    /// within a process or production context. It can contain multiple associated values
    /// that describe measurements or statuses within the event frame.
    /// </remarks>
    public class EventFrameDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the event frame.
        /// </summary>
        /// <example>
        /// "EventFrame_2025_001"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the start time of the event frame in ISO 8601 format.
        /// </summary>
        /// <example>
        /// "2025-10-20T08:00:00Z"
        /// </example>
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the event frame in ISO 8601 format.
        /// </summary>
        /// <example>
        /// "2025-10-20T16:00:00Z"
        /// </example>
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the reference Web ID associated with this event frame.
        /// </summary>
        /// <example>
        /// "DeviceWebId_123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string RefWebId { get; set; }

        /// <summary>
        /// Gets or sets a collection of values associated with this event frame.
        /// </summary>
        /// <remarks>
        /// Each value is represented by an <see cref="EventFrameValueDTO"/> object.
        /// </remarks>
        public List<EventFrameValueDTO> Values { get; set; }
    }
}
