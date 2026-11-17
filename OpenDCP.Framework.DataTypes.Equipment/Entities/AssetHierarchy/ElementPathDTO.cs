namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a single segment or node within an element's hierarchical path.
    /// </summary>
    /// <remarks>
    /// The <see cref="ElementPathDTO"/> provides identifying information about a level
    /// in the asset hierarchy, allowing systems to reconstruct or navigate the
    /// full element path (for example, from a root asset down to a specific device).
    /// </remarks>
    public class ElementPathDTO
    {
        /// <summary>
        /// Gets or sets the name of the element at this hierarchy level.
        /// </summary>
        /// <example>
        /// "Pump Station 1"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the hierarchical level of the element.
        /// </summary>
        /// <remarks>
        /// Levels are often represented as strings indicating the position, within DCP 3 levels are now: level (generic, multiple nesting), group, sensor
        /// </remarks>
        /// <example>
        /// "level"
        /// </example>
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets the unique Web ID associated with the element.
        /// </summary>
        /// <remarks>
        /// The Web ID is a system identifier, commonly used in integration. This should be used when extracting the path, not when searching by path.
        /// </remarks>
        /// <example>
        /// "AbCdEfGhIjKlMnOpQrStUvWxYz123456"
        /// </example>
        public string WebId { get; set; }
    }
}
