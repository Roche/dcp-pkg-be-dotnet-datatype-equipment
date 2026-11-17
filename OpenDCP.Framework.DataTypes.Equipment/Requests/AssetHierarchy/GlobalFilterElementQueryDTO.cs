using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy
{
    public class GlobalFilterElementQueryDTO
    {
        public List<ElementMetaDataDTO> MetaData { get; set; } = new List<ElementMetaDataDTO>();
    }
}
