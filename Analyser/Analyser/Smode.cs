using System;

namespace Analyser
{
    [Flags]
    public enum Smode
    {
        Speed = 256,        // 100000000
        Cadence = 128,      // 010000000
        Altitude = 64,      // 001000000
        Power = 32,         // 000100000
        PowerBalance = 16,  // 000010000
        PowerIndex = 8,     // 000001000
        Imperial = 1,       // 000000001
    }
}
