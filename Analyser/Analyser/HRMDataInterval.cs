using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analyser
{
    class HRMDataInterval
    {
        private int m_bpm, m_speed, m_cadence, m_altitude, m_power, m_powerBalance;

        public HRMDataInterval(int bpm, int speed, int cadence, int altitude, int power, int powerBalance)
        {
            m_bpm = bpm;
            m_speed = speed;
            m_cadence = cadence;
            m_altitude = altitude;
            m_power = power;
            m_powerBalance = powerBalance;
        }
    }
}
