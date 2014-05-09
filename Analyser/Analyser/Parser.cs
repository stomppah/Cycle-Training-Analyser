using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Analyser.Utilities;

namespace Analyser
{
    internal class Parser
    {
        internal ExerciseSession ExerciseSession;
        internal int GuessMaxColumns = 10;

        public ExerciseSession ReadDataFromStream(Stream stream)
        {
            // Read stream line by line
            if (stream != null) {
                StreamReader file = null;
               try {
                  file = new StreamReader(stream);
                   string line;
                   while ((line = file.ReadLine()) != null) {

                      // It's important that this 
                      // is done in the following order.
                      //////////////////////////////////////////
                      switch (line)
                      {
                          case  "[Params]":
                              List<string> paramsList = GetParamsList(line, file);
                              ExerciseSession = new ExerciseSession(paramsList.ToArray());
                              break;
                          case "[Note]":
                              //TODO
                              break;
                          case "[IntTimes]":
                              //TODO
                              break;
                          case "[IntNotes]":
                              //TODO
                              break;
                          case "[ExtraData]":
                              //TODO
                              break;
                          case "[Summary-123]":
                              //TODO
                              break;
                          case "[Summary-TH]":
                              //TODO
                              break;
                          case "[HRZones]":
                              //TODO
                              break;
                          case "[SwapTimes]":
                              //TODO
                              break;
                          case "[Trip]":
                              //
                              break;
                          case "[HRData]":
                              ReadCoreData(line, file);
                              break;
                      }
                      //////////////////////////////////////////

                  }
               } finally {
                  if (file != null)
                     file.Close();
               }
            }

            return ExerciseSession;
        }

        private static List<string> GetParamsList(string line, StreamReader file)
        {
            if (line == null) throw new ArgumentNullException("line");

            var paramIndex = 0;
            var paramsList = new List<string>();

            while ((line = file.ReadLine()) != null && paramIndex < 22)
            {
                if (paramIndex < 22)
                {
                    var paramValue = line.Split('=').ElementAt(1);
                    paramsList.Add(paramValue);
                }

                paramIndex++;
            }
            return paramsList;
        }

        private void ReadCoreData(string line, StreamReader file)
        {
            if (line == null) throw new ArgumentNullException("line");

            var timestamp = new DateTime();

            while ((line = file.ReadLine()) != null)
            {
                // split variable space seperated text
                var tempResults = Regex.Split(line, "\\s+");

                //convert it to Int32 format
                var stats = new Int32[tempResults.Length];
                for (var i = 0; i < tempResults.Length; i++)
                {
                    Int32.TryParse(tempResults[i], out stats[i]);
                }

                
                // how do i add known timespan seconds to datetime
                TimeSpan span = TimeSpan.Parse("0:00:0" + ExerciseSession.Interval.ToString(CultureInfo.InvariantCulture));
                timestamp = timestamp + span;

                ExerciseSession.TimeIntervalList.Add(timestamp.ToShortTimeString());
                ExerciseSession.HeartRateList.Add(stats[0]);
                
                #region Massive switch statement
                switch (stats.Length)
                {
                    case 2: 
                        if(Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Speed))
                            ExerciseSession.SpeedList.Add(stats[1] * 10);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Cadence))
                            ExerciseSession.CadenceList.Add(stats[1]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Altitude))
                            ExerciseSession.AltitudeList.Add(stats[1]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Power))
                            ExerciseSession.PowerList.Add(stats[1]);

                        break;
                    case 3:
                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Speed))
                           ExerciseSession.SpeedList.Add(stats[1] * 10);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Cadence))
                            ExerciseSession.CadenceList.Add(stats[2]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Altitude))
                            ExerciseSession.AltitudeList.Add(stats[2]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Power))
                            ExerciseSession.PowerList.Add(stats[2]);

                        break;
                    case 4:
                        if(Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Speed))
                           ExerciseSession.SpeedList.Add(stats[1] * 10);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Cadence))
                            ExerciseSession.CadenceList.Add(stats[2]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Altitude))
                            ExerciseSession.AltitudeList.Add(stats[3]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Power))
                            ExerciseSession.PowerList.Add(stats[3]);

                        break;
                    case 5:
                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Speed))
                            ExerciseSession.SpeedList.Add(stats[1] * 10);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Cadence))
                            ExerciseSession.CadenceList.Add(stats[2]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Altitude))
                            ExerciseSession.AltitudeList.Add(stats[3]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Power))
                            ExerciseSession.PowerList.Add(stats[4]);

                        break;
                    case 6:
                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Speed))
                            ExerciseSession.SpeedList.Add(stats[1] * 10);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Cadence))
                            ExerciseSession.CadenceList.Add(stats[2]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Altitude))
                            ExerciseSession.AltitudeList.Add(stats[3]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.Power))
                            ExerciseSession.PowerList.Add(stats[4]);

                        if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.PowerBalance))
                            ExerciseSession.PowerBalanceList.Add(stats[5]);

                        //if (Extensions.IsFlagSet(ExerciseSession.CurrentSMode, Smode.PowerIndex))
                        
                        break;
                }
                #endregion

            }

        }
    }
}