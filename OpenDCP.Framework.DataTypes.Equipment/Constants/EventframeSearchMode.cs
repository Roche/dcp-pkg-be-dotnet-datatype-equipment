namespace OpenDCP.Framework.DataTypes.Equipment.Constants
{
    public enum EventframeSearchMode : byte
    {
        //Includes all objects whose start time is within the specified range and end time is December 31, 9999. Also known as "Starting Between and In Progress".
        InProgress = 1,
        // Includes all objects whose start time is within the specified range. Also known as "Starting Between".
        StartInclusive = 2,
        //Includes all objects whose end time is within the specified range. Also known as "Ending Between".
        EndInclusive = 3,
        //Includes all objects whose start and end time are within the specified range. Also known as "Entirely Between".
        Inclusive = 4,
        //Includes all objects whose start or end time overlap with the specified range. Also known as "Active Between".
        Overlapped = 5,
    }
}
