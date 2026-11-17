using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations.Schema;


namespace OpenDCP.Framework.DataTypes.Equipment.Classes
{
    public class Condition
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        [NotMapped]
        public virtual string AttributeName
        {
            get
            {
                return Field.Replace("Values.", "").Replace("_", " ");
            }
        }

        public JObject ConverToKendo()
        {
            var result = new JObject();

            result["field"] = Field;
            result["value"] = Value;
            result["operator"] = Operator;

            return result;
        }
        public JObject ConverToDBRepresentation()
        {
            var result = new JObject();

            result["Field"] = Field;
            result["Value"] = Value;
            result["Operator"] = Operator;

            return result;
        }
    }
}
