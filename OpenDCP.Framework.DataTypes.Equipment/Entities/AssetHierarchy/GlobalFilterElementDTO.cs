using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a globally filterable element within the asset hierarchy,
    /// providing metadata and connectivity information used in data queries or visualizations.
    /// </summary>
    /// <remarks>
    /// The <see cref="GlobalFilterElementDTO"/> is typically used to describe
    /// data points or equipment elements that can be selected or filtered globally
    /// across the application, such as devices, measurement points, or derived values.
    /// </remarks>
    public class GlobalFilterElementDTO
    {
        /// <summary>
        /// Gets or sets the display name of the element.
        /// </summary>
        /// <example>
        /// "Pressure Sensor 101"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the textual description of the element.
        /// </summary>
        /// <example>
        /// "Pressure measurement for tank inlet"
        /// </example>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the unique Web ID of the element.
        /// </summary>
        /// <remarks>
        /// The <see cref="ConnectionManagerAttribute"/> applied to this property indicates
        /// that the Web ID is managed or transformed through the request pipeline.
        /// </remarks>
        /// <example>
        /// "A1b2C3d4E5f6G7h8I9j0K1l2M3n4O5p6"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string WebId { get; set; }

        /// <summary>
        /// Gets or sets the hyperlink or reference path to the element.
        /// </summary>
        /// <example>
        /// "A1b2C3d4E5f6G7h8I9j0K1l2M3n4O5p6/sensor"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the engineering unit of measure (UoM) associated with the element.
        /// </summary>
        /// <example>
        /// "bar"
        /// </example>
        public string UoM { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the element represents a physical device or a grouping element.
        /// </summary>
        /// <example>
        /// true
        /// </example>
        public bool IsDevice { get; set; }

        /// <summary>
        /// Gets or sets the data type or value type associated with the element.
        /// </summary>
        /// <example>
        /// "Double", "String", "Boolean"
        /// </example>
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the element is associated with a chromatographic unit.
        /// </summary>
        /// <remarks>
        /// Used in analytical or laboratory contexts to identify chromatograph-related assets.
        /// </remarks>
        /// <example>
        /// false
        /// </example>
        public bool IsChromUnit { get; set; }

        /// <summary>
        /// Gets or sets the list of category names associated with the element.
        /// </summary>
        /// <example>
        /// ["Pressure", "Critical Measurement"]
        /// </example>
        public List<string> CategoryNames { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the element's data is represented as stepwise values.
        /// </summary>
        /// <remarks>
        /// Stepwise values indicate that the signal remains constant until the next change (e.g., digital or discrete data).
        /// </remarks>
        /// <example>
        /// true
        /// </example>
        public bool Step { get; set; }
    }
}
