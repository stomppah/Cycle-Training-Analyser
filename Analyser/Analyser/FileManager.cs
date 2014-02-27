using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyser
{
    internal static class FileManager
    {
        internal static Stream stream;
        internal static Parser parser = new Parser();
        internal static List<HRMDataSet> Stats;

        internal static void LoadFile(OpenFileDialog openFileDialog1)
        {
            string loadFile = "";
            openFileDialog1.Title = "Load cycle training data.";
            openFileDialog1.FileName = "";

            openFileDialog1.Filter = "HRM Files|*.hrm";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                loadFile = openFileDialog1.FileName;

                stream = File.Open(loadFile, FileMode.Open);

                Stats = parser.ReadDataFromStream(stream);


                
                stream.Close();

            }
        }
    }
}
