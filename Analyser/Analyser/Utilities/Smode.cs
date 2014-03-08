using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser.Utilities
{
    [Flags]
    public enum Smode
    {
        AirPressure = 1,    // 000000001
        Imperial = 2,       // 000000010
        CyclingData = 4,    // 000000100
        PowerIndex = 8,     // 000001000
        PowerBalance = 16,  // 000010000
        PowerOutput = 32,   // 000100000
        Altitude = 64,      // 001000000
        Cadence = 128,      // 010000000
        Speed = 256         // 100000000
    }
}
