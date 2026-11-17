namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents an event frame value with an associated Web ID, extending <see cref="EventFrameValueDTO"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventFrameValueWithIdDTO"/> includes all properties of <see cref="EventFrameValueDTO"/>
    /// (Name, Value, Good) and adds a Web ID for uniquely identifying the value in external systems.
    /// </remarks>
    public class EventFrameValueWithIdDTO : EventFrameValueDTO
    {
        /// <summary>
        /// Gets or sets the Web ID associated with this value.
        /// </summary>
        /// <example>
        /// "ValueWebId_123456"
        /// </example>
        public string WebId { get; set; }
    }
}
