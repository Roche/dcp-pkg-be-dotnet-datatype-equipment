using System;

namespace OpenDCP.Framework.DataTypes.Equipment.Extensions
{
    internal static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }

    }
}
