using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a device within the asset hierarchy, including its identification,
    /// descriptive information, and associated categories.
    /// </summary>
    /// <remarks>
    /// This DTO is used to transfer basic device information between system components.
    /// It typically appears in contexts where devices are listed, referenced, or mapped
    /// to higher-level equipment structures.
    /// </remarks>
    public class DeviceDTO
    {
        /// <summary>
        /// Gets or sets the display name of the device.
        /// </summary>
        /// <example>
        /// "Compressor A1"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique Web ID of the device.
        /// </summary>
        /// <remarks>
        /// The Web ID serves as a unique identifier within external systems or APIs.
        /// </remarks>
        /// <example>
        /// "F1AbCdEfGhIjKlMnOpQrStUvWxYz"
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
        /// Gets or sets a description of the device, providing additional
        /// information about its function or purpose.
        /// </summary>
        /// <example>
        /// "Main air compressor for production line 1"
        /// </example>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the hierarchical path of the device within the asset structure.
        /// </summary>
        /// <remarks>
        /// The path represents the ordered hierarchy of elements leading to this device,
        /// starting from a root or top-level asset and progressing through intermediate
        /// levels (such as generic levels, groups, and sensors).
        /// Each entry in the collection corresponds to a single hierarchy level and is
        /// represented by an <see cref="ElementPathDTO"/>.
        /// </remarks>
        public List<ElementPathDTO> Path { get; set; } = new List<ElementPathDTO>();

        /// <summary>
        /// Gets or sets a collection of category names that classify the device.
        /// </summary>
        /// <remarks>
        /// Categories can be used for grouping, filtering, or tagging devices
        /// in reports and asset visualizations.
        /// </remarks>
        /// <example>
        /// ["Rotating Equipment", "Compressed Air System"]
        /// </example>
        public List<string> CategoryNames { get; set; }
    }
}
