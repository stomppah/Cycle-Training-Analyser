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
        internal List<HRMData> hrmData = new List<HRMData>();
        internal int guessMaxColumns = 10;

        public Parser() { }

        public List<HRMData> ReadDataFromStream(Stream stream)
        {
            // Read stream line by line
            string line;
            if (stream != null) {
                StreamReader file = null;
               try {
                  file = new StreamReader(stream);
                  while ((line = file.ReadLine()) != null) {

                      // split variable space seperated text
                      string[] tempResults = Regex.Split(line, "\\s+");

                      //convert it to Int32 format
                      Int32[] stats = new Int32[tempResults.Length];
                      for (int i = 0; i < tempResults.Length; i++ )
                      {
                          Int32.TryParse(tempResults[i], out stats[i]);
                      }

                      hrmData.Add(stats);
                  }
               } finally {
                  if (file != null)
                     file.Close();
               }
            }

            return hrmData;
        }

    }
}
