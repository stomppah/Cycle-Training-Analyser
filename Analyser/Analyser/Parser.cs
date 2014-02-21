using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Analyser
{
    internal class Parser
    {
        internal List<string[]> hrmData = new List<string[]>();
        internal int guessMaxColumns = 10;

        public Parser() { }

        public List<string[]> ReadDataFromStream(Stream stream)
        {
            // Read stream line by line
            string line;
            if (stream != null) {
                StreamReader file = null;
               try {
                  file = new StreamReader(stream);
                  while ((line = file.ReadLine()) != null) {

                      // split line into columns and stick them in the list here
                      string[] stats = line.Split(' ');
                      hrmData.Add(stats);

                      foreach (string stat in stats) 
                      {  
                         Debug.WriteLine(stat);
                      }
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
