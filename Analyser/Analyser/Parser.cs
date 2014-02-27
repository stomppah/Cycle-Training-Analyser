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
        internal HRMDataSet m_hrmDataSet;
        internal int guessMaxColumns = 10;

        public Parser() { }

        public HRMDataSet ReadDataFromStream(Stream stream)
        {
            List<string> paramsList;

            // Read stream line by line
            string line;
            if (stream != null) {
                StreamReader file = null;
               try {
                  file = new StreamReader(stream);
                  while ((line = file.ReadLine()) != null) {




                      //////////////////////////////////////////
                      switch (line)
                      {
                          case  "[Params]":
                              paramsList = GetParamsList(line, file);
                              break;
                          default:
                              ReadCoreData(line);
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

            while ((line = file.ReadLine()) != null)
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

        private void ReadCoreData(string line)
        {

            // split variable space seperated text
            string[] tempResults = Regex.Split(line, "\\s+");

            //convert it to Int32 format
            Int32[] stats = new Int32[tempResults.Length];
            for (int i = 0; i < tempResults.Length; i++)
            {
                Int32.TryParse(tempResults[i], out stats[i]);
            }

            //m_hrmDataSet.Add(stats);
        }

    }
}
