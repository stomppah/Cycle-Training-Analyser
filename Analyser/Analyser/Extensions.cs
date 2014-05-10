using System.Diagnostics;

namespace Analyser
{
    /// <summary>
    /// Responsible for displaying runtime information.
    /// </summary>
    public static class Extensions
    {       
        public static void Logger(string output)
        {
            Debug.WriteLine("Debug Logger: " + output.Trim());
        }

        public static bool IsFlagSet(Smode bitmask, Smode flag)
        {
            return (bitmask & flag) != 0;
        }

    }

}
