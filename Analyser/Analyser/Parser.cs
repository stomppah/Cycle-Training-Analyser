using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Analyser
{
    internal class Parser
    {
        internal SessionDataList HrmDataSet;
        internal int GuessMaxColumns = 10;

        public SessionDataList ReadDataFromStream(Stream stream)
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
                              HrmDataSet = new SessionDataList(paramsList.ToArray());
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

            return HrmDataSet;
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

                var interval = new SessionDataInterval {Bpm = stats[0]};

                //TODO
                if (stats.Length >= 5)
                {
                    interval.Speed = stats[1] * 10;
                    interval.Cadence = stats[2];
                    interval.Altitude = stats[3];
                    interval.Power = stats[4];
                    interval.PowerBalance = stats[5];
                }
                    
                HrmDataSet.Add(interval);
            }

        }
    }
}