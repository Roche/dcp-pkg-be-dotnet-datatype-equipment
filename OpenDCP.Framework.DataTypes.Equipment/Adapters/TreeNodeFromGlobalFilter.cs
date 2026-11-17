using OpenDCP.Framework.Configuration.Model.Interfaces;
using OpenDCP.Framework.DataTypes.Equipment.Entities.AssetHierarchy;
using OpenDCP.Framework.DataTypes.Equipment.Interfaces;
using OpenDCP.Framework.DataTypes.Equipment.Requests.AssetHierarchy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.Equipment.Adapters
{
    public class TreeNodeFromGlobalFilter : ITreeNode<GlobalFilterElementDTO>
    {
        private readonly IAssetHierarchyDataSource _datasource;

        public TreeNodeFromGlobalFilter(IAssetHierarchyDataSource datasource) => _datasource = datasource;

        public async Task<List<GlobalFilterElementDTO>> FindByAttributesAsync(Dictionary<string, object> attributes)
        {
            var model = new GlobalFilterElementQueryDTO
            {
                MetaData = attributes.Select(x => new ElementMetaDataDTO
                {
                    Name = x.Key,
                    Value = x.Value as string
                }).ToList()
            };
            var el = await _datasource.SearchGlobalFilterElementsAsync(model);
            return el.Elements;
        }

        public async Task<GlobalFilterElementDTO> FindByIdAsync(string id)
        {
            var el = await _datasource.GetGlobalFilterElementAsync(id);
            return el.Element;
        }

        public async Task<GlobalFilterElementDTO> FindByPathAsync(List<(string id, string role, string name)> path)
        {
            var model = new GlobalFilterElementByPathRequest
            {
                Path = path
                .Select(p => new ElementPathDTO
                {
                    Name = p.name,
                    Level = p.role,
                    WebId = p.id
                })
                .ToList()
            };

            var el = await _datasource.GetGlobalFilterElementAsync(model);
            return el.Element;
        }

        public async Task<Dictionary<string, object>> GetAttribtuesAsync(string id)
        {
            var el = await _datasource.GetElementMetaDataAsync(id);
            return el.MetaData.ToDictionary(x => x.Name, x => (object)x.Value);
        }

        public async Task<List<GlobalFilterElementDTO>> GetChildrenAsync(string link)
        {
            var el = await _datasource.GetGlobalFilterAsync(link);
            return el.Elements;
        }

        public string GetId(GlobalFilterElementDTO el)
        {
            return el.WebId;
        }

        public string GetLink(GlobalFilterElementDTO el)
        {
            return el.Link;
        }

        public async Task<GlobalFilterElementDTO> GetParentAsync(string id)
        {
            var el = await _datasource.GetPreviousGlobalFilterAsync(id);
            return el.Element;
        }

        public async Task<List<(string id, string role, string name)>> GetPathAsync(string id)
        {
            var el = await _datasource.GetGlobalFilterBackwardsAsync(id);
            return el.Elements.Select(x => (x.WebId, x.Link.Split('/').Last(), x.Name)).ToList();
        }
    }
}