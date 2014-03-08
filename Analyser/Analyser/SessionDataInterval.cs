using Analyser.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analyser
{
    class SessionDataInterval
    {
        private int m_bpm, m_speed, m_cadence, m_altitude, m_power, m_powerBalance;

        public SessionDataInterval() 
        {

        }

        public int Speed { get { return m_speed; } set { m_speed = value; } }

        public int Cadence { get { return m_cadence; } set { m_cadence = value; } }

        public int Altitude { get { return m_altitude; } set { m_altitude = value; } }

        public int Bpm { get { return m_bpm; } set { m_bpm = value; } }

        public int Power { get { return m_power; } set { m_power = value; } }

        public int PowerBalance { get { return m_powerBalance; } set { m_powerBalance = value; } }
    }
}
