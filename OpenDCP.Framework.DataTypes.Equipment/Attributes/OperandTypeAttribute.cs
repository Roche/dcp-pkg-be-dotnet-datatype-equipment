using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class OperandTypeAttribute : Attribute
    {
        public string OperandType { get; }
        public OperandTypeAttribute(string type) => OperandType = type;
    }
}
