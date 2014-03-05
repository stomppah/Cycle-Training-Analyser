using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    class HRMDataList : IList<HRMDataInterval>
    {
        private IList<HRMDataInterval> m_hrmDataIntervals = new List<HRMDataInterval>();

        #region [Params]
        public int m_version, m_montior, m_smode;
        public DateTime m_date, m_startTime, m_length;
        public int m_interval;
        public int m_upper1, m_lower1, m_upper2, m_lower2, m_upper3, m_lower3;
        public TimeSpan m_timer1, m_timer2, m_timer3;
        public int m_activeLimit, m_maxHR, m_restHR, m_startDelay, m_vo2max, m_weight;
        #endregion

        public HRMDataList() { }

        public HRMDataList(string[] paramsList)
        {
            Int32.TryParse(paramsList[0], out m_version);
            Int32.TryParse(paramsList[1], out m_montior);
            Int32.TryParse(paramsList[2], out m_smode);
            DateTime.TryParse(paramsList[3], out m_date);
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

        #region IList Interface
        public int IndexOf(HRMDataInterval item)
        {
            return this.m_hrmDataIntervals.IndexOf(item);
        }

        public void Insert(int index, HRMDataInterval item)
        {
            this.m_hrmDataIntervals.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.m_hrmDataIntervals.RemoveAt(index);
        }

        public HRMDataInterval this[int index]
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

        public void Add(HRMDataInterval item)
        {
            this.m_hrmDataIntervals.Add(item);
        }

        public void Clear()
        {
            this.m_hrmDataIntervals.Clear();
        }

        public bool Contains(HRMDataInterval item)
        {
            return this.m_hrmDataIntervals.Contains(item);
        }

        public void CopyTo(HRMDataInterval[] array, int arrayIndex)
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

        public bool Remove(HRMDataInterval item)
        {
            return this.m_hrmDataIntervals.Remove(item);
        }

        public IEnumerator<HRMDataInterval> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
