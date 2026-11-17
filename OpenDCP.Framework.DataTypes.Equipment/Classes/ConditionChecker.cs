using OpenDCP.Framework.DataTypes.Equipment.Constants;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext;
using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenDCP.Framework.DataTypes.Equipment.Classes
{
    public static class ConditionChecker
    {
        public static List<ConditionRejectReason> ApplyBatchConditionAsync(List<EventFrameValueDTO> batchValues, List<Condition> conditions)
        {
            List<ConditionRejectReason> conditionFails = new List<ConditionRejectReason>();

            foreach (var item in conditions)
            {

                //extract batch values from intermediate table
                var currentValue = batchValues.FirstOrDefault(x => x.Name == item.AttributeName);

                //Populate result with values which does not met the conditions
                //Case where into BatchIntermediate into JBatchValues column there is a "Name" is not into Model Conditions
                if (currentValue != null)
                {

                    if (!currentValue.Good)
                    {
                        var currentOperator = LegacyConditionOperatorType.operators.Where(x => x.Value == item.Operator).FirstOrDefault();
                        ConditionRejectReason conditionFailWithBadValue = new ConditionRejectReason
                        {
                            FieldName = item.Field,
                            Current = Convert.ToString(currentValue.Value),
                            Expected = item.Value,
                            Operator = currentOperator.Value,
                            BadValue = true
                        };
                        conditionFails.Add(conditionFailWithBadValue);
                        //If we detect at least ONE bad value for attribute which is been used as condition => we do not need to check anymore
                        break;
                    }


                    ConditionRejectReason conditionFail = CheckIfConditionFail(item.Operator, item.Value, Convert.ToString(currentValue.Value), item.AttributeName);
                    if (conditionFail != null)
                    {
                        conditionFail.BadValue = false;
                        conditionFail.FieldName = item.Field;
                        conditionFails.Add(conditionFail);
                    }
                }
                //Attribute/s defined in DCP is no longer part of the event frame template and corresponding device defined on PI
                else
                {
                    ConditionRejectReason conditionFailWithMissingAttribute = new ConditionRejectReason
                    {
                        IsDeletedAttributeOnAFStructure = true,
                    };
                    conditionFails.Add(conditionFailWithMissingAttribute);
                    //If we detect at least ONE missing attribute which is been used as condition => we do not need to check anymore
                    //and we treated as Conditions Not Match
                    break;
                }
            }

            //If all values met the condition, result is empty
            return conditionFails;
        }

        private static ConditionRejectReason CheckIfConditionFail(string conditionOperator, string conditionValue, string currentValue, string fieldName)
        {
            ConditionRejectReason result = null;

            var currentOperator = LegacyConditionOperatorType.operators.Where(x => x.Value == conditionOperator).FirstOrDefault();
            if (currentOperator.Type == "number")
            {
                if (!decimal.TryParse(conditionValue, out decimal dConditionValue) || !decimal.TryParse(currentValue, out decimal dCurrentValue))
                {
                    return result;
                }

                if (conditionOperator == LegacyConditionOperatorType.gt)
                {
                    if (dConditionValue >= dCurrentValue)
                    {

                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.gte)
                {
                    if (dConditionValue > dCurrentValue)
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.lt)
                {
                    if (dConditionValue <= dCurrentValue)
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.lte)
                {
                    if (dConditionValue < dCurrentValue)
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.eq)
                {
                    if (dConditionValue != dCurrentValue)
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.neq)
                {
                    if (dConditionValue == dCurrentValue)
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
            }
            if (currentOperator.Type == "string")
            {
                if (conditionOperator == LegacyConditionOperatorType.contains)
                {
                    if (!currentValue.Contains(conditionValue, StringComparison.CurrentCultureIgnoreCase))
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.doesnotcontain)
                {
                    if (currentValue.Contains(conditionValue, StringComparison.CurrentCultureIgnoreCase))
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.startswith)
                {
                    if (!currentValue.StartsWith(conditionValue, StringComparison.CurrentCultureIgnoreCase))
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
                if (conditionOperator == LegacyConditionOperatorType.endswith)
                {
                    if (!currentValue.EndsWith(conditionValue, StringComparison.CurrentCultureIgnoreCase))
                    {
                        result = new ConditionRejectReason { FieldName = fieldName, Current = currentValue, Expected = conditionValue, Operator = currentOperator.Value };
                    }
                }
            }

            return result;
        }
    }

}
