using Analyser.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    class SessionDataList : IList<SessionDataInterval>
    {
        public IList<SessionDataInterval> m_hrmDataIntervals = new List<SessionDataInterval>();

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

        #region [Params]
        public int m_version, m_montior, m_smode;
        public DateTime m_date, m_startTime, m_length;
        public int m_interval;
        public int m_upper1, m_lower1, m_upper2, m_lower2, m_upper3, m_lower3;
        public TimeSpan m_timer1, m_timer2, m_timer3;
        public int m_activeLimit, m_maxHR, m_restHR, m_startDelay, m_vo2max, m_weight;
        #endregion

        public SessionDataList() { }

        public SessionDataList(string[] paramsList)
        {
            Int32.TryParse(paramsList[0], out m_version);
            Int32.TryParse(paramsList[1], out m_montior);
            Int32.TryParse(paramsList[2], out m_smode);

            Smode smode = (Smode) m_smode;

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

            int year, month, day;
            Int32.TryParse(paramsList[3].Substring(0, 4), out year);
            Int32.TryParse(paramsList[3].Substring(4, 2), out month);
            Int32.TryParse(paramsList[3].Substring(6, 2), out day);
            m_date = new DateTime(year, month, day);
            DateTime.TryParse(paramsList[4], out m_startTime);
            DateTime.TryParse(paramsList[5], out m_length);
            
            Int32.TryParse(paramsList[6], out m_interval);
            Int32.TryParse(paramsList[7], out m_upper1);
            Int32.TryParse(paramsList[8], out m_lower1);
            Int32.TryParse(paramsList[9], out m_upper2);
            Int32.TryParse(paramsList[10], out m_lower2);
            Int32.TryParse(paramsList[11], out m_upper3);
            Int32.TryParse(paramsList[12], out m_lower3);

            TimeSpan.TryParse(paramsList[13], out m_timer1);
            TimeSpan.TryParse(paramsList[14], out m_timer2);
            TimeSpan.TryParse(paramsList[15], out m_timer3);
            Int32.TryParse(paramsList[16], out m_activeLimit);
            Int32.TryParse(paramsList[17], out m_maxHR);
            Int32.TryParse(paramsList[18], out m_restHR);

            Int32.TryParse(paramsList[19], out m_startDelay);
            Int32.TryParse(paramsList[20], out m_vo2max);
            Int32.TryParse(paramsList[21], out m_weight);
        }

        static bool IsFlagSet(Smode bitmask, Smode flag)
        {
            return (bitmask & flag) != 0;
        }

        #region IList Interface
        public int IndexOf(SessionDataInterval item)
        {
            return this.m_hrmDataIntervals.IndexOf(item);
        }

        public void Insert(int index, SessionDataInterval item)
        {
            this.m_hrmDataIntervals.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.m_hrmDataIntervals.RemoveAt(index);
        }

        public SessionDataInterval this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(SessionDataInterval item)
        {
            this.m_hrmDataIntervals.Add(item);
        }

        public void Clear()
        {
            this.m_hrmDataIntervals.Clear();
        }

        public bool Contains(SessionDataInterval item)
        {
            return this.m_hrmDataIntervals.Contains(item);
        }

        public void CopyTo(SessionDataInterval[] array, int arrayIndex)
        {
            this.m_hrmDataIntervals.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return this.m_hrmDataIntervals.Count; }
        }

        public bool IsReadOnly
        {
            get { return this.m_hrmDataIntervals.IsReadOnly; }
        }

        public bool Remove(SessionDataInterval item)
        {
            return this.m_hrmDataIntervals.Remove(item);
        }

        public IEnumerator<SessionDataInterval> GetEnumerator()
        {
            return this.m_hrmDataIntervals.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.m_hrmDataIntervals.GetEnumerator();
        }
        #endregion
    }
}
