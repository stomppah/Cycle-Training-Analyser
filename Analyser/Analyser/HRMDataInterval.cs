using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analyser
{
    class HRMDataInterval
    {
        private int m_bpm, m_speed, m_cadence, m_altitude, m_power, m_powerBalance;

        public HRMDataInterval( int[] data ) // bpm, int speed, int cadence, int altitude, int power, int powerBalance)
        {
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
