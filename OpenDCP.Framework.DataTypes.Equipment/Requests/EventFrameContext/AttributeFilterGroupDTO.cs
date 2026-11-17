using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext.Conditions;
using System.Collections.Generic;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    public class AttributeFilterGroupDTO
    {
        public List<AttributeFilterDTO> Filters { get; set; } = new List<AttributeFilterDTO>();
        public List<AttributeFilterGroupDTO> Groups { get; set; } = new List<AttributeFilterGroupDTO>();
        public ConditionGroupOperator Operator { get; set; } = ConditionGroupOperator.And;
    }
}
