using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.SensorData;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.SensorData
{
    public class SensorDataChunksResponse : DatasourceResponse
    {
        public List<SensorDataChunkDTO> Chunks { get; set; } = new List<SensorDataChunkDTO>();
    }

}
