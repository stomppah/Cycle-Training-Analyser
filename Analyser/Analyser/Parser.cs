﻿using Analyser.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Analyser
{
    internal class Parser
    {
        internal SessionDataList m_hrmDataSet;
        internal int guessMaxColumns = 10;

        public Parser() { }

        public SessionDataList ReadDataFromStream(Stream stream)
        {
            List<string> paramsList;

            // Read stream line by line
            string line;
            if (stream != null) {
                StreamReader file = null;
               try {
                  file = new StreamReader(stream);
                  while ((line = file.ReadLine()) != null) {



                      // It's important that this 
                      // is done in the following order.
                      //////////////////////////////////////////
                      switch (line)
                      {
                          case  "[Params]":
                              paramsList = GetParamsList(line, file);
                              m_hrmDataSet = new SessionDataList(paramsList.ToArray());
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

                          default:
                              break;
                      }
                      //////////////////////////////////////////


                  }
               } finally {
                  if (file != null)
                     file.Close();
               }
            }

            return m_hrmDataSet;
        }

        private static List<string> GetParamsList(string line, StreamReader file)
        {
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

                var smode = m_hrmDataSet.CurrentSMode;
                var interval = new SessionDataInterval();

                interval.Bpm = stats[0];

                if (stats.Length >= 5)
                {
                    interval.Speed = stats[1] * 10;
                    interval.Cadence = stats[2];
                    interval.Altitude = stats[3];
                    interval.Power = stats[4];
                    interval.PowerBalance = stats[5];
                }
                    
                m_hrmDataSet.Add(interval);
            }
        }

    }
}
