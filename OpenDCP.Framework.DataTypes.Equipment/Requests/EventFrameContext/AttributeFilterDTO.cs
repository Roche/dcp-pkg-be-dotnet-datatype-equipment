using OpenDCP.Framework.DataTypes.Equipment.Constants;

namespace OpenDCP.Framework.DataTypes.Equipment.Requests.EventFrameContext
{
    public class AttributeFilterDTO
    {
        public string Name { get; set; }
        public ConditionOperatorType Operator { get; set; }
        public object Value { get; set; }
    }
}
