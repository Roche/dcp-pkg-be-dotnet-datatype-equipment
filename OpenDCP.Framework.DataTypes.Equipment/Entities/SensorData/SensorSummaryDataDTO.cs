using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData
{
    public class SensorSummaryDataDTO
    {
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Transform)]
        public string WebId { get; set; }
        public string Name { get; set; }
        public string UoM { get; set; }
        public List<SensorStatisticValueDTO> DataPoints { get; set; }
    }
}
