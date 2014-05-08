using System;
using System.Globalization;
using System.Windows.Forms;

namespace Analyser
{
    public partial class MainForm : Form
    {
        private SessionDataList _currentSessionDataList = new SessionDataList();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentSessionDataList = FileManager.LoadFile(OpenFileDialog);
            UpdateGui();
        }

        private void generateGraphButton_Click(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        #region Update GUI
        private void UpdateGui()
        {
            UpdateSummaryInfo();

            UpdateDataGrid();

            UpdateGraph();
        }

        private void UpdateSummaryInfo()
        {
            nameLabel.Text = "Duncan Mullier";
            dateLabel.Text = _currentSessionDataList.Date.ToLongDateString();
            timeLabel.Text = _currentSessionDataList.StartTime.ToLongTimeString();
            durationLabel.Text = _currentSessionDataList.Length.ToLocalTime().ToString();

            int maxHr = _currentSessionDataList.MaxHr;
            int minHr = _currentSessionDataList.RestHr;
            int avgHr = (minHr + maxHr) / 2;

            MaxHeartRateLabel.Text = maxHr.ToString(CultureInfo.InvariantCulture);
            minHeartRateLabel.Text = minHr.ToString(CultureInfo.InvariantCulture);

            averageHeartRateLabel.Text = avgHr.ToString(CultureInfo.InvariantCulture);

        }

        private void UpdateDataGrid()
        {
            foreach (var interval in _currentSessionDataList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = interval.Bpm.ToString(CultureInfo.InvariantCulture);
                row.Cells[1].Value = interval.Speed.ToString(CultureInfo.InvariantCulture);
                row.Cells[2].Value = interval.Cadence.ToString(CultureInfo.InvariantCulture);
                row.Cells[3].Value = interval.Altitude.ToString(CultureInfo.InvariantCulture);
                row.Cells[4].Value = interval.Power.ToString(CultureInfo.InvariantCulture);
                row.Cells[5].Value = interval.PowerBalance.ToString(CultureInfo.InvariantCulture);
                dataGridView1.Rows.Add(row);
            }
        }

        private void UpdateGraph()
        {
            if (!zedGraphControl1.Visible)
                zedGraphControl1.Visible = true;

            Grapher.UpdateGraph(ref zedGraphControl1, ref _currentSessionDataList);
        }
        #endregion

    }
}
