using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents a collection of values associated with a specific event frame.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventFrameValuesDTO"/> contains the unique identifier of the event frame
    /// and a list of attribute values (<see cref="EventFrameValueDTO"/>) measured or recorded during the event frame.
    /// </remarks>
    public class EventFrameValuesDTO
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
        /// Gets or sets the collection of values associated with this event frame.
        /// </summary>
        /// <remarks>
        /// Each value is represented by an <see cref="EventFrameValueDTO"/> object.
        /// </remarks>
        /// <example>
        /// [
        ///   { Name = "Temperature", Value = 23.5, Good = true },
        ///   { Name = "Pressure", Value = 1.2, Good = true }
        /// ]
        /// </example>
        public List<EventFrameValueDTO> Values { get; set; }
    }
}
