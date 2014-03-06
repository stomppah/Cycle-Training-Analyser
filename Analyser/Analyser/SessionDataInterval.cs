using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analyser
{
    class SessionDataInterval
    {
        internal int m_bpm, m_speed, m_cadence, m_altitude, m_power, m_powerBalance;

        public SessionDataInterval( int[] data ) // bpm, int speed, int cadence, int altitude, int power, int powerBalance)
        {
            // How this works needs a complete rework to account for the variability of the SMODE parameter.
            m_bpm = data[0];
            m_speed = data[1];
            m_cadence = data[2];
            m_altitude = data[3];
            m_power = data[4];
            m_powerBalance = data[5];
        }

        public string StringOutput()
        {
            return m_bpm + " " + m_speed + " " + m_cadence + " " + m_altitude + " " + m_power + " " + m_powerBalance;
        }
    }
}
