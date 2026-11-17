using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToIso8601String(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
        }
    }
}
