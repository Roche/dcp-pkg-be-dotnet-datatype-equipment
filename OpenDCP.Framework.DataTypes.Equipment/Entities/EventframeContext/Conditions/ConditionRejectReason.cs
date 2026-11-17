namespace OpenDCP.Framework.DataTypes.Equipment.Entities.EventframeContext.Conditions
{
    public class ConditionRejectReason
    {
        public string FieldName { get; set; }
        public string Current { get; set; }
        public string Expected { get; set; }
        public string Operator { get; set; }
        /// <summary>
        /// True when bad value been detected for given Attribute
        /// </summary>
        public bool BadValue { get; set; }
        /// <summary>
        /// True when Attribute defined in DCP is no longer part of the event frame template and corresponding device defined on the datasource otherwise false
        /// </summary>
        public bool IsDeletedAttributeOnAFStructure { get; set; }
    }
}
