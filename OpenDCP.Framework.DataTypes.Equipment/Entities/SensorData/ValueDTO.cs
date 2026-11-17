using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData
{
    public class ValueDTO
    {
        public DateTime ObsId { get; set; }
        public bool Good { get; set; }
        public dynamic Value { get; set; }
    }
}
