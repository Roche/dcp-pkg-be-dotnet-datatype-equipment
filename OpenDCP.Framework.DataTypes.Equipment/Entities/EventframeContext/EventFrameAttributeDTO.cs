namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents an attribute of an event frame, including its metadata and measurement configuration.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventFrameAttributeDTO"/> describes the name, description, value type,
    /// and unit of measure (UoM) of a particular attribute associated with an event frame.
    /// </remarks>
    public class EventFrameAttributeDTO
    {
        /// <summary>
        /// Gets or sets the name of the attribute.
        /// </summary>
        /// <example>
        /// "Temperature"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a textual description of the attribute.
        /// </summary>
        /// <example>
        /// "Measured temperature of the compressor outlet"
        /// </example>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the data type of the attribute's value.
        /// </summary>
        /// <example>
        /// "Double", "Boolean", "String"
        /// </example>
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or sets the engineering unit of measure (UoM) associated with the attribute.
        /// </summary>
        /// <example>
        /// "°C", "bar"
        /// </example>
        public string UoM { get; set; }
    }
}
