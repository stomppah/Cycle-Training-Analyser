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
            CycleStatsListBox.DataSource = FileManager.m_hrmDataList.m_hrmDataIntervals;
            dataGridView1.DataSource = FileManager.m_hrmDataList.m_hrmDataIntervals;
        }
    }
}
