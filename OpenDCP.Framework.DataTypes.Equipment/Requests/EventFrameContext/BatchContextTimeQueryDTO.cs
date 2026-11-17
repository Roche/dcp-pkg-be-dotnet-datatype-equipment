using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.DataTypes.Equipment.Constants;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    /// <summary>
    /// Data transfer object used for request purposes to query batch context within a specific time interval.
    /// </summary>
    public class BatchContextTimeQueryDTO
    {
        /// <summary>
        /// Gets or sets the start date and time of the search interval.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the search interval.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the search logic used to identify relevant event frames (e.g., Overlapped).
        /// Defaults to <see cref="EventframeSearchMode.Overlapped"/>.
        /// </summary>
        public EventframeSearchMode SearchMode { get; set; } = EventframeSearchMode.Overlapped;

        /// <summary>
        /// Gets or sets the list of device WebIDs to filter the batch context by specific equipment or assets.
        /// </summary>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> DeviceWebId { get; set; } = new List<string>();
    }
}
