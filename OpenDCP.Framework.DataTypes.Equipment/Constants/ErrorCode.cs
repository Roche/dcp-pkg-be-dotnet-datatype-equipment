namespace OpenDCP.Framework.DataTypes.Equipment.Constants
{
    public enum ErrorCode : byte
    {
        NoError = 0,
        DeleteSensor = 1,
        DeleteDevice = 2,
        DeletedTemplate = 3,
        DeletedEventFrameWebId = 4,
        ParsingError = 5,
        NotFound = 6,
        //TODO remove this when we made the refactoring in Core
        NoSuccessStatusCode = 99

    }
}
