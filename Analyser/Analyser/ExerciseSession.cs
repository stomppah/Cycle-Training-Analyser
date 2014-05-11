using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel;

namespace Analyser
{
    public class ExerciseSession
    {
        #region [Params]
        public BindingList<double> TimeIntervalList = new BindingList<double>();
        public BindingList<double> HeartRateList = new BindingList<double>();
        public BindingList<double> SpeedList = new BindingList<double>();
        public BindingList<double> CadenceList = new BindingList<double>();
        public BindingList<double> AltitudeList = new BindingList<double>();
        public BindingList<double> PowerList = new BindingList<double>();
        public BindingList<double> PowerBalanceList = new BindingList<double>();
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

        public ExerciseSession(IList<string> paramsList)
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

        public Smode CurrentSMode
        {
            get { return Flags; }
        }

        #region Average Properties
        public double AverageBpm
        {
            get { return Math.Round((HeartRateList.Sum()/HeartRateList.Count), 2); }
        }

        public double AverageSpeed
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Speed) ? Math.Round((SpeedList.Sum()/SpeedList.Count), 2) : 0; }
        }

        public double AverageCadence
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Cadence) ? Math.Round((CadenceList.Sum()/CadenceList.Count), 2) : 0; }
        }

        public double AverageAltitude
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Altitude) ? Math.Round((AltitudeList.Sum()/AltitudeList.Count), 2) : 0; }
        }

        public double AveragePower
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Power) ? Math.Round((PowerList.Sum()/PowerList.Count), 2) : 0; }
        }
        #endregion

        #region Max Properties
        public double MaxBpm
        {
            get { return HeartRateList.Max(); }
        }

        public double MaxSpeed
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Speed) ? SpeedList.Max() : 0; }
        }

        public double MaxCadence
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Cadence) ? CadenceList.Max() : 0; }
        }

        public double MaxAltitude
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Altitude) ? AltitudeList.Max() : 0; }
        }

        public double MaxPower
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Power) ? PowerList.Max() : 0; }
        }

        #endregion

        #region Min Properties
        public double MinBpm
        {
            get { return HeartRateList.Min(); }
        }

        public double MinSpeed
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Speed) ? SpeedList.Min() : 0; }
        }

        public double MinCadence
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Cadence) ? CadenceList.Min() : 0; }
        }

        public double MinAltitude
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Altitude) ? AltitudeList.Min() : 0; }
        }

        public double MinPower
        {
            get { return Extensions.IsFlagSet(CurrentSMode, Smode.Power) ? PowerList.Min() : 0; }
        }
        #endregion
    }
}
