using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy
{
    /// <summary>
    /// Represents a sensor within the asset hierarchy, including its identification,
    /// metadata, and measurement configuration.
    /// </summary>
    /// <remarks>
    /// The <see cref="SensorDTO"/> provides the essential information required to describe
    /// a sensor connected to a device or equipment element. It can be used to retrieve
    /// sensor readings, categorize sensors, or configure data mappings.
    /// </remarks>
    public class SensorDTO
    {
        /// <summary>
        /// Gets or sets the display name of the sensor.
        /// </summary>
        /// <example>
        /// "Temperature Sensor A1"
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique Web ID of the sensor.
        /// </summary>
        /// <example>
        /// "AbCdEfGhIjKlMnOpQrStUvWxYz123456"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string WebId { get; set; }

        /// <summary>
        /// Gets or sets the Web ID of the device to which the sensor is associated.
        /// </summary>
        /// <remarks>
        /// This property links the sensor to its parent device in the asset hierarchy.
        /// </remarks>
        /// <example>
        /// "XyZ987654321AbCdEfGh"
        /// </example>
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string DeviceWebId { get; set; }

        /// <summary>
        /// Gets or sets a textual description of the sensor.
        /// </summary>
        /// <example>
        /// "Monitors the temperature of the compressor outlet"
        /// </example>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the data type of the sensor's measured value.
        /// </summary>
        /// <example>
        /// "Double", "Boolean", "String"
        /// </example>
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or sets the engineering unit of measure (UoM) associated with the sensor.
        /// </summary>
        /// <example>
        /// "°C", "bar", "m³/h"
        /// </example>
        public string UoM { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sensor produces stepwise (discrete) values.
        /// </summary>
        /// <remarks>
        /// Stepwise data means the value remains constant until a change occurs — for example,
        /// for on/off states or discrete signal changes.
        /// </remarks>
        /// <example>
        /// false
        /// </example>
        public bool IsStep { get; set; }

        /// <summary>
        /// Gets or sets a collection of category names assigned to the sensor.
        /// </summary>
        /// <remarks>
        /// Categories are used for grouping, tagging, or filtering sensors in reports or UIs.
        /// </remarks>
        /// <example>
        /// ["Temperature", "Process Monitoring"]
        /// </example>
        public List<string> CategoryNames { get; set; }
    }
}
