using Analyser.Utilities;
using System;
using System.Collections.Generic;

namespace Analyser
{
    class SessionDataList : IList<SessionDataInterval>
    {
        public IList<SessionDataInterval> HrmDataIntervals = new List<SessionDataInterval>();

        #region [Params]
        public int 
            Version, 
            Montior, 
            Smode, 
            Interval, 
            Upper1, 
            Lower1, 
            Upper2, 
            Lower2, 
            Upper3, 
            Lower3, 
            ActiveLimit, 
            MaxHr, 
            RestHr, 
            StartDelay, 
            Vo2Max, 
            Weight;
        public DateTime Date, StartTime, Length;
        public TimeSpan Timer1, Timer2, Timer3;
        #endregion

        public SessionDataList() { }

        public SessionDataList(string[] paramsList)
        {
            Int32.TryParse(paramsList[0], out Version);
            Int32.TryParse(paramsList[1], out Montior);
            Int32.TryParse(paramsList[2], out Smode);

            int year, month, day;
            Int32.TryParse(paramsList[3].Substring(0, 4), out year);
            Int32.TryParse(paramsList[3].Substring(4, 2), out month);
            Int32.TryParse(paramsList[3].Substring(6, 2), out day);
            Date = new DateTime(year, month, day);
            DateTime.TryParse(paramsList[4], out StartTime);
            DateTime.TryParse(paramsList[5], out Length);
            
            Int32.TryParse(paramsList[6], out Interval);
            Int32.TryParse(paramsList[7], out Upper1);
            Int32.TryParse(paramsList[8], out Lower1);
            Int32.TryParse(paramsList[9], out Upper2);
            Int32.TryParse(paramsList[10], out Lower2);
            Int32.TryParse(paramsList[11], out Upper3);
            Int32.TryParse(paramsList[12], out Lower3);

            TimeSpan.TryParse(paramsList[13], out Timer1);
            TimeSpan.TryParse(paramsList[14], out Timer2);
            TimeSpan.TryParse(paramsList[15], out Timer3);
            Int32.TryParse(paramsList[16], out ActiveLimit);
            Int32.TryParse(paramsList[17], out MaxHr);
            Int32.TryParse(paramsList[18], out RestHr);

            Int32.TryParse(paramsList[19], out StartDelay);
            Int32.TryParse(paramsList[20], out Vo2Max);
            Int32.TryParse(paramsList[21], out Weight);
        }

        #region IList Interface
        public int IndexOf(SessionDataInterval item)
        {
            return HrmDataIntervals.IndexOf(item);
        }

        public void Insert(int index, SessionDataInterval item)
        {
            HrmDataIntervals.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            HrmDataIntervals.RemoveAt(index);
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
            HrmDataIntervals.Add(item);
        }

        public void Clear()
        {
            HrmDataIntervals.Clear();
        }

        public bool Contains(SessionDataInterval item)
        {
            return HrmDataIntervals.Contains(item);
        }

        public void CopyTo(SessionDataInterval[] array, int arrayIndex)
        {
            HrmDataIntervals.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return HrmDataIntervals.Count; }
        }

        public bool IsReadOnly
        {
            get { return HrmDataIntervals.IsReadOnly; }
        }

        public bool Remove(SessionDataInterval item)
        {
            return HrmDataIntervals.Remove(item);
        }

        public IEnumerator<SessionDataInterval> GetEnumerator()
        {
            return HrmDataIntervals.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return HrmDataIntervals.GetEnumerator();
        }
        #endregion

        public Smode CurrentSMode { get { return (Smode) Smode; } }
    }
}
