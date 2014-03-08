using System;
using System.Diagnostics;

namespace Analyser.Utilities
{
    /// <summary>
    /// Responsible for displaying runtime information.
    /// </summary>
    internal static class Logger
    {
       
        internal static void Write(string output)
        {
            Debug.WriteLine("Debug Logger: " + output.Trim());
        }

    }

}
