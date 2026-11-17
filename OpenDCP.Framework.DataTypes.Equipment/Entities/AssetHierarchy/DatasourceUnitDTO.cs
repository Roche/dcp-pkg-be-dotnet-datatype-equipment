namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a single data source unit within an asset hierarchy.
    /// </summary>
    /// <remarks>
    /// A <see cref="DatasourceUnit"/> describes the basic identifying information
    /// of a unit used in an equipment or asset context, such as its class,
    /// display name, and abbreviation.
    /// </remarks>
    public class DatasourceUnit
    {
        /// <summary>
        /// Gets or sets the data source unit class, representing the physical measurement. All units within a class can be converted by factors.
        /// </summary>
        /// <example>
        /// "pressure", "temperature", "mass flow rate"
        /// </example>
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the display name of the data source unit.
        /// </summary>
        /// <example>
        /// "Degree Celsius"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the abbreviation or short code used to identify the data source unit.
        /// </summary>
        /// <example>
        /// "mbar"
        /// </example>
        public string Abbreviation { get; set; }
    }
}
