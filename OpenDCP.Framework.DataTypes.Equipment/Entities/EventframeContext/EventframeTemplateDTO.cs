using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents a reference to an event frame template associated with a specific device.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventframeTemplateDTO"/> provides basic identification information
    /// for a template, including its name, Web ID, and the associated device Web ID.
    /// </remarks>
    public class EventframeTemplateDTO
    {
        /// <summary>
        /// Gets or sets the name of the template.
        /// </summary>
        /// <example>
        /// "Compressor Event Template"
        /// </example>
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the Web ID of the device associated with this template.
        /// </summary>
        /// <example>
        /// "DeviceWebId_123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string DeviceWebId { get; set; }

        /// <summary>
        /// Gets or sets the Web ID of the template.
        /// </summary>
        /// <example>
        /// "TemplateWebId_987654"
        /// </example>
        public string TemplateWebId { get; set; }
    }
}
