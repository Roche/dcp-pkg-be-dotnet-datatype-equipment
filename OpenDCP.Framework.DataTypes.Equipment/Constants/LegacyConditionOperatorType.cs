using OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext.Conditions;
using System.Collections.Generic;
using System.ComponentModel;


namespace OpenDCP.Framework.DataTypes.Equipment.Constants
{
    public class LegacyConditionOperatorType
    {
        public const string contains = "contains";
        public const string doesnotcontain = "doesnotcontain";
        public const string startswith = "startswith";
        public const string endswith = "endswith";
        public const string eq = "eq";
        public const string neq = "neq";
        public const string lt = "lt";
        public const string lte = "lte";
        public const string gt = "gt";
        public const string gte = "gte";
        public static List<ConditionOperator> operators = new List<ConditionOperator>()
            {
                new ConditionOperator {Name = "Contains" , Value = "contains" , Type = "string"  },
                new ConditionOperator {Name = "Does not contain" , Value = "doesnotcontain" , Type = "string"  },
                new ConditionOperator {Name = "Starts with" , Value = "startswith" , Type = "string"  },
                new ConditionOperator {Name = "Ends with" , Value = "endswith" , Type = "string"  },
                new ConditionOperator {Name = "Is equal" , Value = "eq" , Type = "number"  },
                new ConditionOperator {Name = "Is not equal" , Value = "neq" , Type = "number"  },
                new ConditionOperator {Name = "Less than" , Value = "lt" , Type = "number"  },
                new ConditionOperator {Name = "Less than or equal" , Value = "lte" , Type = "number"  },
                new ConditionOperator {Name = "Greater than" , Value = "gt" , Type = "number"  },
                new ConditionOperator {Name = "Greater than or equal" , Value = "gte" , Type = "number"  },
            };
    }
}
