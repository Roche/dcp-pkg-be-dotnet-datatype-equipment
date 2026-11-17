namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents a single value associated with an event frame, including its name, value, and quality status.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventFrameValueDTO"/> is used to store the measured or recorded value of an attribute
    /// within an event frame, along with an indicator of whether the value is considered good/valid.
    /// </remarks>
    public class EventFrameValueDTO
    {
        /// <summary>
        /// Gets or sets the name of the attribute or measurement.
        /// </summary>
        /// <example>
        /// "Temperature"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the attribute. 
        /// </summary>
        /// <remarks>
        /// This property is dynamic to accommodate various types of values (e.g., double, string, boolean).
        /// </remarks>
        /// <example>
        /// 23.5
        /// </example>
        public dynamic Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the measurement is considered good/valid.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>. A value of <c>false</c> may indicate sensor errors, invalid readings, or data issues.
        /// </remarks>
        /// <example>
        /// true
        /// </example>
        public bool Good { get; set; } = true;
    }
}
