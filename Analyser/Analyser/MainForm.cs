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
            ZedGraph.GraphPane myPane = new GraphPane();
            // how do i draw a graph with zedgraph
            double x1, y1, y2;
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            for (int i = 0; i < 36; i++)
            {
                x1 = (double)i + 1;
                y1 = 1.5 + Math.Sin((double)i * 0.2);
                y2 = 3.0 * (1.5 + Math.Sin((double)i * 0.2));
                list1.Add(x1, y1);
                list2.Add(x1, y2);
            }
            LineItem myCurve = myPane.AddCurve("Porsche", list1, Color.Red, SymbolType.Diamond);
            LineItem myCurve2 = myPane.AddCurve("Piper", list2, Color.Blue, SymbolType.Circle);

        }

        #region Update GUI
        private void UpdateGUI()
        {
            UpdateHeaderInfo();

            UpdateSummaryInfo();

            UpdateDataGrid();   
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
        }

        private void UpdateDataGrid()
        {
            foreach (var interval in m_currentSessionDataList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = interval.m_bpm.ToString();
                row.Cells[1].Value = interval.m_speed.ToString();
                row.Cells[2].Value = interval.m_cadence.ToString();
                row.Cells[3].Value = interval.m_altitude.ToString();
                row.Cells[4].Value = interval.m_power.ToString();
                row.Cells[5].Value = interval.m_powerBalance.ToString();
                dataGridView1.Rows.Add(row);
            }
        }
        #endregion

    }
}
