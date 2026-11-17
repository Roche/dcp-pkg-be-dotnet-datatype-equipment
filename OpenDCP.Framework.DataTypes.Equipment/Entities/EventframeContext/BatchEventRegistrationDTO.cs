namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents the registration details of a batch event for a device.
    /// </summary>
    /// <remarks>
    /// The <see cref="BatchEventRegistrationDTO"/> contains information about the device,
    /// associated site, module name, and whether the registration is for a GxP-compliant process.
    /// </remarks>
    public class BatchEventRegistrationDTO
    {
        /// <summary>
        /// Gets or sets the Web ID of the device associated with the batch event.
        /// </summary>
        /// <example>
        /// "DeviceWebId_123456"
        /// </example>
        public string DeviceWebId { get; set; }

        /// <summary>
        /// Gets or sets the optional site identifier associated with the batch event.
        /// </summary>
        /// <remarks>
        /// This can be null if the batch event is not tied to a specific site.
        /// </remarks>
        /// <example>
        /// 101
        /// </example>
        public int? SiteId { get; set; }

        /// <summary>
        /// Gets or sets the name of the registration source (DCP module).
        /// </summary>
        /// <example>
        /// "MVDA"
        /// </example>
        public string ModuleName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the registration source is GxP-compliant.
        /// </summary>
        /// <example>
        /// true
        /// </example>
        public bool IsGxp { get; set; }
    }
}
