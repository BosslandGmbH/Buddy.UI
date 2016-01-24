using System;

namespace Buddy.UI.Core
{
    /// <summary>
    /// Class containing various methods to aid in precondition checking. 
    /// </summary>
    internal static class Requires
    {
        public static void NotNull<T>(T value, string parameterName) where T : class
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
        }

        public static void NotNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(parameterName);
        }
    }
}
