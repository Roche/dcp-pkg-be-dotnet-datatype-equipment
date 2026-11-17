using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy
{
    public class GlobalFilterElementByPathRequest
    {
        public List<ElementPathDTO> Path { get; set; } = new List<ElementPathDTO>();
    }
}
