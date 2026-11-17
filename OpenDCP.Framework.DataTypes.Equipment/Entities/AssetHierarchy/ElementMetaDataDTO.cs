namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a metadata entry associated with an asset element.
    /// </summary>
    /// <remarks>
    /// The <see cref="ElementMetaDataDTO"/> is used to store descriptive or technical metadata
    /// about an equipment element, such as configuration parameters, specifications,
    /// or contextual information.
    /// </remarks>
    public class ElementMetaDataDTO
    {
        /// <summary>
        /// Gets or sets the name of the metadata field.
        /// </summary>
        /// <example>
        /// "Manufacturer"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a short description of the metadata field.
        /// </summary>
        /// <example>
        /// "Name of the company that produced the equipment"
        /// </example>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value associated with the metadata field.
        /// </summary>
        /// <example>
        /// "Siemens AG"
        /// </example>
        public string Value { get; set; }
    }
}
