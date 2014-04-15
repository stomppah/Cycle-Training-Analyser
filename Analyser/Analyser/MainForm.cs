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
            UpdateHeaderInfo();

            UpdateSummaryInfo();

            UpdateDataGrid();

            UpdateGraph();
        }

        private void UpdateHeaderInfo()
        {
            versionLabel.Text = _currentSessionDataList.Version.ToString(CultureInfo.InvariantCulture);
            monitorLabel.Text = _currentSessionDataList.Montior.ToString(CultureInfo.InvariantCulture);
            if (smodeLabel != null) smodeLabel.Text = _currentSessionDataList.Smode.ToString(CultureInfo.InvariantCulture);
        }

        private void UpdateSummaryInfo()
        {
            dateLabel.Text = _currentSessionDataList.Date.ToLongDateString();
            startTimeLabel.Text = _currentSessionDataList.StartTime.ToLongTimeString();
            lengthLabel.Text = _currentSessionDataList.Length.ToLongTimeString();
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
