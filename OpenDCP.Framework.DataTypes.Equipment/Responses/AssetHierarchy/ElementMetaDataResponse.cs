using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Responses.AssetHierarchy
{
    public class ElementMetaDataResponse : DatasourceResponse
    {
        public List<ElementMetaDataDTO> MetaData { get; set; } = new List<ElementMetaDataDTO>();
    }
}
