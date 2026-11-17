using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a group of sensors, including the sensors themselves and the group name.
    /// </summary>
    /// <remarks>
    /// The <see cref="SensorGroupDTO"/> is used to organize sensors into logical collections,
    /// for example, by function, location, or device. It helps in filtering, reporting,
    /// and UI grouping of sensors.
    /// </remarks>
    public class SensorGroupDTO
    {
        /// <summary>
        /// Gets or sets the list of sensors belonging to this group.
        /// </summary>
        /// <remarks>
        /// Each sensor in the list is represented by a <see cref="SensorDTO"/> object.
        /// </remarks>
        /// <example>
        /// [
        ///   { Name = "Temperature Sensor A1", WebId = "AbCd1234", ... },
        ///   { Name = "Pressure Sensor B1", WebId = "EfGh5678", ... }
        /// ]
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Reduce)]
        public List<SensorDTO> Sensors { get; set; }

        /// <summary>
        /// Gets or sets the name of the sensor group.
        /// </summary>
        /// <example>
        /// "Compressor Sensors"
        /// </example>
        public string GroupName { get; set; }
    }
}
