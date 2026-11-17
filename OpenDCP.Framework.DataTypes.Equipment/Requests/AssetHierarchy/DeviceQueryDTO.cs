using OpenDCP.Framework.Configuration.Model.Attributes;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy
{
    public class DeviceQueryDTO
    {
        public string NameQuery { get; set; } = null;
        [ConnectionManagerAttribute(Configuration.Model.Constants.Datasource.RequestPipelineAction.Map)]
        public List<string> WebIds {  get; set; } = new List<string>();
    }
}
