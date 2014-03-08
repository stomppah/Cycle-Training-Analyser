using Analyser.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analyser
{
    class SessionDataInterval
    {
        internal int m_bpm, m_speed, m_cadence, m_altitude, m_power, m_powerBalance;

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

        public SessionDataInterval( int[] data ) // bpm, int speed, int cadence, int altitude, int power, int powerBalance)
        {
            Smode smode = (Smode)111111100;

            if (IsFlagSet(smode, Smode.Speed))
            {
                Logger.Write("Speed flag is set.");
            }

            if (IsFlagSet(smode, Smode.Cadence))
            {
                Logger.Write("Cadence flag is set.");
            }

            if (IsFlagSet(smode, Smode.Altitude))
            {
                Logger.Write("Altitude flag is set.");
            }

            if (IsFlagSet(smode, Smode.PowerOutput))
            {
                Logger.Write("Power Output flag is set.");
            }

            if (IsFlagSet(smode, Smode.PowerBalance))
            {
                Logger.Write("Power Balance flag is set.");
            }

            if (IsFlagSet(smode, Smode.PowerIndex))
            {
                Logger.Write("Power Index flag is set.");
            }

            if (IsFlagSet(smode, Smode.CyclingData))
            {
                Logger.Write("Cycling Data flag is set.");
            }

            if (IsFlagSet(smode, Smode.Imperial))
            {
                Logger.Write("Imperial Units flag is set.");
            }
            // How this works needs a complete rework to account for the variability of the SMODE parameter.
            m_bpm = data[0];
            m_speed = data[1];
            m_cadence = data[2];
            m_altitude = data[3];
            m_power = data[4];
            m_powerBalance = data[5];
        }

        static bool IsFlagSet(Smode bitmask, Smode flag)
        {
            return (bitmask & flag) != 0;
        }
    }
}
