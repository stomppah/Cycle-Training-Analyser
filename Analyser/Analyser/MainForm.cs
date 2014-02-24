using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyser
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.LoadFile(OpenFileDialog);
            List<string> list = new List<string>();
            foreach (var item in FileManager.Stats)
            {
                string str = "";
                for (int i = 0; i < item.Length; i++)
                {
                    str += item.GetValue(i).ToString() + " ";
                }
                list.Add(str);
            }
            CycleStatsListBox.DataSource = list;
        }
    }
}
