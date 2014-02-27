using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    class HRMDataSet : IList<HRMDataInterval>
    {
        private IList<HRMDataInterval> m_hrmDataInterval;

        #region [Params]
        private int m_version, m_montior;
        private byte m_smode;
        private DateTime m_date, m_startTime, m_length;
        private int m_interval;
        private int m_upper1, m_lower1, m_upper2, m_lower2, m_upper3, m_lower3;
        private TimeSpan m_timer1, m_timer2, m_timer3;
        private int m_activeLimit, m_maxHR, m_restHR, m_startDelay, m_vo2max, m_weight;
        #endregion

        #region IList Interface
        public int IndexOf(HRMDataInterval item)
        {
            return this.m_hrmDataInterval.IndexOf(item);
        }

        public void Insert(int index, HRMDataInterval item)
        {
            this.m_hrmDataInterval.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.m_hrmDataInterval.RemoveAt(index);
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
            this.m_hrmDataInterval.Add(item);
        }

        public void Clear()
        {
            this.m_hrmDataInterval.Clear();
        }

        public bool Contains(HRMDataInterval item)
        {
            return this.m_hrmDataInterval.Contains(item);
        }

        public void CopyTo(HRMDataInterval[] array, int arrayIndex)
        {
            this.m_hrmDataInterval.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return this.m_hrmDataInterval.Count; }
        }

        public bool IsReadOnly
        {
            get { return this.m_hrmDataInterval.IsReadOnly; }
        }

        public bool Remove(HRMDataInterval item)
        {
            return this.m_hrmDataInterval.Remove(item);
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
