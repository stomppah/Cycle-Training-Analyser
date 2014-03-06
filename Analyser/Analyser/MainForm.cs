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
            // Lets generate sine and cosine wave
            double[] x = new double[100];
            double[] y = new double[100];
            double[] z = new double[100];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = Math.Sin(0.3 * x[i]);
                z[i] = Math.Cos(0.3 * x[i]);
            }

            // This is to remove all plots
            zedGraphControl1.GraphPane.CurveList.Clear();

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphControl1.GraphPane;

            // PointPairList holds the data for plotting, X and Y arrays 
            PointPairList spl1 = new PointPairList(x, y);
            PointPairList spl2 = new PointPairList(x, z);

            // Add cruves to myPane object
            LineItem myCurve1 = myPane.AddCurve("Sine Wave", spl1, Color.Blue, SymbolType.None);
            LineItem myCurve2 = myPane.AddCurve("Cosine Wave", spl2, Color.Red, SymbolType.None);

            myCurve1.Line.Width = 3.0F;
            myCurve2.Line.Width = 3.0F;
            myPane.Title.Text = "My First Plot";

            // I add all three functions just to be sure it refeshes the plot.   
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
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
