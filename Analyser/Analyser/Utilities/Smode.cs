using System;

namespace Analyser.Utilities
{
    [Flags]
    public enum Smode
    {
        Speed = 256,        // 100000000
        Cadence = 128,      // 010000000
        Altitude = 64,      // 001000000
        PowerOutput = 32,   // 000100000
        Imperial = 1,       // 000000001
    }

    //bit 7 (highest, first character of string) indicates that speed has been recorded.

    //bit 6 indicates that cadence has been recorded.

    //bit 5 indicates that altitude has been recorded.

    //bit 4 indicates that power output has been recorded.

    //bits 1-3 represent the bike number.

    //bit 0 (lowest, last character of string) is set to 1 for imperial, to 0 for metric units.

}
