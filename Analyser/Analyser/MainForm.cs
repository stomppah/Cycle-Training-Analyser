using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Analyser
{
    public partial class MainForm : Form
    {
        private SessionDataList m_currentSessionDataList = new SessionDataList();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_currentSessionDataList = FileManager.LoadFile(OpenFileDialog);
            UpdateGUI();
        }

        private void generateGraphButton_Click(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        #region Update GUI
        private void UpdateGUI()
        {
            UpdateHeaderInfo();

            UpdateSummaryInfo();

            UpdateDataGrid();

            UpdateGraph();
        }

        private void UpdateHeaderInfo()
        {
            versionLabel.Text = m_currentSessionDataList.m_version.ToString();
            monitorLabel.Text = m_currentSessionDataList.m_montior.ToString();
            smodeLabel.Text = m_currentSessionDataList.m_smode.ToString();
        }

        private void UpdateSummaryInfo()
        {
            dateLabel.Text = m_currentSessionDataList.m_date.ToLongDateString();
            startTimeLabel.Text = m_currentSessionDataList.m_startTime.ToLongTimeString();
            lengthLabel.Text = m_currentSessionDataList.m_length.ToLongTimeString();
        }

        private void UpdateDataGrid()
        {
            foreach (var interval in m_currentSessionDataList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = interval.Bpm.ToString();
                row.Cells[1].Value = interval.Speed.ToString();
                row.Cells[2].Value = interval.Cadence.ToString();
                row.Cells[3].Value = interval.Altitude.ToString();
                row.Cells[4].Value = interval.Power.ToString();
                row.Cells[5].Value = interval.PowerBalance.ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        private void UpdateGraph()
        {
            if (!zedGraphControl1.Visible)
                zedGraphControl1.Visible = true;

            Grapher.UpdateGraph(ref zedGraphControl1, ref m_currentSessionDataList);
        }
        #endregion

    }
}
