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

        internal static void LoadFile(OpenFileDialog openFileDialog1)
        {
            string loadFile = "";
            openFileDialog1.Title = "Load saved game state.";
            openFileDialog1.FileName = "";

            openFileDialog1.Filter = "GOL Files|*.gol";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //BinaryFormatter bformatter = new BinaryFormatter();
                //m_Grid = (Grid)bformatter.Deserialize(stream);

                loadFile = openFileDialog1.FileName;

                //Open the file written above and read values from it.
                Stream stream = File.Open(loadFile, FileMode.Open);
                
                stream.Close();

            }
        }
    }
}
