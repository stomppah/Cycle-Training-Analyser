using System.Linq;
using System.Text;
using Analyser.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Analyser
{
    class ExerciseSession
    {
        #region [Params]
        public BindingList<DateTime> TimeIntervalList = new BindingList<DateTime>();
        public BindingList<int> HeartRateList = new BindingList<int>();
        public BindingList<int> SpeedList = new BindingList<int>();
        public BindingList<int> CadenceList = new BindingList<int>();
        public BindingList<int> AltitudeList = new BindingList<int>();
        public BindingList<int> PowerList = new BindingList<int>();
        public BindingList<int> PowerBalanceList = new BindingList<int>();
        public Smode Flags;
        public int 
            Version, 
            Montior, 
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

        #region Contructors
        public ExerciseSession() { }

        public ExerciseSession(string[] paramsList)
        {
            #region Extract data 
            Int32.TryParse(paramsList[0], out Version);
            Int32.TryParse(paramsList[1], out Montior);

            Flags = (Smode)Convert.ToInt32(paramsList[2], 2);

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
            #endregion
        }
        #endregion

        public Smode CurrentSMode { get { return Flags; } }

        public double AverageBpm { get { return HeartRateList.Sum() / HeartRateList.Count; } }

        public double AverageSpeed { get { return SpeedList.Count > 0 ? SpeedList.Sum()/SpeedList.Count : 0; } }

        public double AverageAltitude { get { return AltitudeList.Count > 0 ? AltitudeList.Sum()/AltitudeList.Count : 0; } }

        public double AveragePower { get { return PowerList.Count > 0 ? PowerList.Sum()/PowerList.Count : 0; } }
    }
}
