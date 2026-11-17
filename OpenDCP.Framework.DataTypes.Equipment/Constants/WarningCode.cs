namespace OpenDCP.Framework.DataTypes.Equipment.Constants
{
    public enum WarningCode : byte
    {
        Success = 0,
        ExceedBatchTotalCount = 1,
        DeletedAttributeWebId = 2,
        NoArchivedValues = 3,
        DeletedElementWebId = 4
    }
}
