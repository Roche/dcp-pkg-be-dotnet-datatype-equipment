using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents an attribute in an event frame template, including metadata, categories, and measurement configuration.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventframeTemplateAttributeDTO"/> is used to define the attributes
    /// that are part of a template for event frames, including their names, value types,
    /// units of measure, and whether they require manual data entry.
    /// </remarks>
    public class EventframeTemplateAttributeDTO
    {
        /// <summary>
        /// Gets or sets the name of the attribute.
        /// </summary>
        /// <example>
        /// "Temperature"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Web ID of the attribute.
        /// </summary>
        /// <example>
        /// "AttrWebId_123456"
        /// </example>
        public string WebId { get; set; }

        /// <summary>
        /// Gets or sets a description of the attribute.
        /// </summary>
        /// <example>
        /// "Measured temperature of the process outlet"
        /// </example>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the data type of the attribute's value.
        /// </summary>
        /// <example>
        /// "Double", "String", "Boolean"
        /// </example>
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attribute requires manual data entry.
        /// </summary>
        /// <example>
        /// true
        /// </example>
        public bool IsManualDataEntry { get; set; }

        /// <summary>
        /// Gets or sets the engineering unit of measure (UoM) associated with the attribute.
        /// </summary>
        /// <example>
        /// "°C", "bar"
        /// </example>
        public string UoM { get; set; }

        /// <summary>
        /// Gets or sets the list of category names associated with this attribute.
        /// </summary>
        /// <remarks>
        /// Categories are used for grouping, filtering, or tagging attributes in templates and UIs.
        /// </remarks>
        /// <example>
        /// ["Process Measurement", "Critical"]
        /// </example>
        public List<string> CategoryNames { get; set; }
    }
}
