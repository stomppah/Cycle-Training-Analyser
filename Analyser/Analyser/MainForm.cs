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
        private SessionDataList m_hrmDataList = new SessionDataList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_hrmDataList = FileManager.LoadFile(OpenFileDialog);
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            // Update header info
            versionLabel.Text = m_hrmDataList.m_version.ToString();
            monitorLabel.Text = m_hrmDataList.m_montior.ToString();
            smodeLabel.Text = m_hrmDataList.m_smode.ToString();

            // Update summary info
            dateLabel.Text = m_hrmDataList.m_date.ToLongDateString();
            startTimeLabel.Text = m_hrmDataList.m_startTime.ToLongTimeString();
            
        }

    }
}
