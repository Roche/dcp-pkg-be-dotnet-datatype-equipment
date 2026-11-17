using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData
{
    public class SensorStatisticValueDTO
    {
        public DateTime ObsId { get; set; }
        public string SummaryType { get; set; }
        public bool Good { get; set; }
        public dynamic Value { get; set; }
    }
}
