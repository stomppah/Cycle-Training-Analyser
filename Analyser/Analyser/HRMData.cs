using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    class HRMData : IList<Interval>
    {
        private IList<Interval> stats;

        #region [Params]
        private int m_version, m_montior;
        private byte m_smode;
        private DateTime m_date, m_startTime, m_length;
        private int m_interval;
        private int m_upper1, m_lower1, m_upper2, m_lower2, m_upper3, m_lower3;
        private TimeSpan m_timer1, m_timer2, m_timer3;
        private int m_activeLimit, m_maxHR, m_restHR, m_startDelay, m_vo2max, m_weight;
        #endregion

    }
}
