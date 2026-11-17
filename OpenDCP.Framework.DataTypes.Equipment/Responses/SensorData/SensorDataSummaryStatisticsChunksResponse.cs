using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.SensorData
{
    public class SensorDataSummaryStatisticsChunksResponse : DatasourceResponse
    {
        public List<SensorSummaryDataChunkDTO> Chunks { get; set; } = new List<SensorSummaryDataChunkDTO>();
    }

}
