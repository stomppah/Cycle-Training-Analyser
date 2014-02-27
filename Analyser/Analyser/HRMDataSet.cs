using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    class HRMDataSet : IList<HRMDataInterval>
    {
        private IList<HRMDataInterval> m_hrmDataIntervals;

        #region [Params]
        public int m_version, m_montior;
        public byte m_smode;
        public DateTime m_date, m_startTime, m_length;
        public int m_interval;
        public int m_upper1, m_lower1, m_upper2, m_lower2, m_upper3, m_lower3;
        public TimeSpan m_timer1, m_timer2, m_timer3;
        public int m_activeLimit, m_maxHR, m_restHR, m_startDelay, m_vo2max, m_weight;
        #endregion

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
