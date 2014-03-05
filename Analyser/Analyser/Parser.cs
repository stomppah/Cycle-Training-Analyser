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
        internal HRMDataList m_hrmDataSet;
        internal int guessMaxColumns = 10;

        public Parser() { }

        public HRMDataList ReadDataFromStream(Stream stream)
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
                              m_hrmDataSet = new HRMDataList(paramsList.ToArray());
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
            int paramIndex = 0;
            List<string> paramsList = new List<string>();

            while ((line = file.ReadLine()) != null && paramIndex < 22)
            {
                if (paramIndex < 22)
                {
                    string paramValue = line.Split('=').ElementAt(1);
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
                string[] tempResults = Regex.Split(line, "\\s+");

                //convert it to Int32 format
                Int32[] stats = new Int32[tempResults.Length];
                for (int i = 0; i < tempResults.Length; i++)
                {
                    Int32.TryParse(tempResults[i], out stats[i]);
                }

                m_hrmDataSet.Add(
                    new HRMDataInterval(stats)
                    );
            }
        }

    }
}
