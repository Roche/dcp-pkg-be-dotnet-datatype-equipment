using OpenDCP.Framework.DataTypes.Equipment.Attributes;
using System.ComponentModel;

namespace OpenDCP.Framework.DataTypes.Equipment.Constants
{
    public enum ConditionOperatorType
    {
        [Description("Contains")]
        [OperandType("string")]
        contains = 1,

        [Description("DoesNotContain")]
        [OperandType("string")]
        doesnotcontain = 2,

        [Description("StartsWith")]
        [OperandType("string")]
        startswith = 3,

        [Description("EndsWith")]
        [OperandType("string")]
        endswith = 4,

        [Description("Equal")]
        [OperandType("number")]
        eq = 5,

        [Description("NotEqual")]
        [OperandType("number")]
        neq = 6,

        [Description("LessThan")]
        [OperandType("number")]
        lt = 7,

        [Description("LessThanOrEqual")]
        [OperandType("number")]
        lte = 8,

        [Description("GreaterThan")]
        [OperandType("number")]
        gt = 9,

        [Description("GreaterThanOrEqual")]
        [OperandType("number")]
        gte = 10
    }

}
