using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a specific level within the global filter hierarchy, 
    /// containing the selected element and all available sibling options for that level.
    /// </summary>
    /// <remarks>
    /// This DTO is used to facilitate cascading filters in the user interface, 
    /// allowing the system to present a breadcrumb-like structure where each level 
    /// knows both its current state and its alternative possibilities.
    /// </remarks>
    public class GlobalFilterLevelDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier (typically a Web ID) of the currently selected element at this hierarchy level.
        /// </summary>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the list of all available elements that can be selected at this specific hierarchy level.
        /// </summary>
        /// <remarks>
        /// These options represent the "siblings" of the selected element, 
        /// which share the same parent in the asset hierarchy.
        /// </remarks>
        public List<GlobalFilterElementDTO> Options { get; set; } = new List<GlobalFilterElementDTO>();
    }
}
