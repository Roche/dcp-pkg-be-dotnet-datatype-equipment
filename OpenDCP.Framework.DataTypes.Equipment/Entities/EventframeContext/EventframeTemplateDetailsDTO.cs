using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext
{
    /// <summary>
    /// Represents the details of an event frame template, including its unique identifier, name, and associated attributes.
    /// </summary>
    /// <remarks>
    /// The <see cref="EventframeTemplateDetailsDTO"/> provides the structure and metadata for an event frame template,
    /// including all attributes defined for the template.
    /// </remarks>
    public class EventframeTemplateDetailsDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier (GUID) of the template.
        /// </summary>
        /// <example>
        /// "d290f1ee-6c54-4b01-90e6-d701748f0851"
        /// </example>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the Web ID of the template.
        /// </summary>
        /// <example>
        /// "TemplateWebId_123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string WebId { get; set; }

        /// <summary>
        /// Gets or sets the name of the template.
        /// </summary>
        /// <example>
        /// "Compressor Event Template"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of attributes associated with this template.
        /// </summary>
        /// <remarks>
        /// Each attribute is represented by an <see cref="EventFrameAttributeDTO"/> object.
        /// </remarks>
        /// <example>
        /// [
        ///   { Name = "Temperature", ValueType = "Double", UoM = "°C" },
        ///   { Name = "Pressure", ValueType = "Double", UoM = "bar" }
        /// ]
        /// </example>
        public List<EventFrameAttributeDTO> Attributes { get; set; }
    }
}
