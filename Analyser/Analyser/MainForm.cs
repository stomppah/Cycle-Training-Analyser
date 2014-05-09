using System;
using System.Globalization;
using System.Windows.Forms;
using Analyser.Utilities;

namespace Analyser
{
    public partial class MainForm : Form
    {
        private ExerciseSession _currentExerciseSession = new ExerciseSession();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentExerciseSession = FileManager.LoadFile(OpenFileDialog);
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

            UpdateRecordedStats();

            UpdateDataGrid();

            UpdateGraph();
        }

        private void UpdateSummaryInfo()
        {
            nameLabel.Text = "Duncan Mullier";
            dateLabel.Text = _currentExerciseSession.Date.ToLongDateString();
            timeLabel.Text = _currentExerciseSession.StartTime.ToLongTimeString();
            durationLabel.Text = _currentExerciseSession.Length.ToLongTimeString();

            int maxHr = _currentExerciseSession.MaxHr;
            int minHr = _currentExerciseSession.RestHr;

            MaxHeartRateLabel.Text = maxHr.ToString(CultureInfo.InvariantCulture);
            minHeartRateLabel.Text = minHr.ToString(CultureInfo.InvariantCulture);

            averageHeartRateLabel.Text = _currentExerciseSession.AverageBpm.ToString(CultureInfo.InvariantCulture) + " bpm";
            averageSpeedLabel.Text = _currentExerciseSession.AverageSpeed.ToString(CultureInfo.InvariantCulture) + " km/h";
            averageAltitudeLabel.Text = _currentExerciseSession.AverageAltitude.ToString(CultureInfo.InvariantCulture) + " m";
            averagePowerLabel.Text = _currentExerciseSession.AveragePower.ToString(CultureInfo.InvariantCulture) + " Watts";
        }

        private void UpdateRecordedStats()
        {
            if (Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, Smode.Speed))
            {
                checkedSmodeList.SetItemChecked(1, true);
            }
            if (Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, Smode.Cadence))
            {
                checkedSmodeList.SetItemChecked(2, true);
            }
            if (Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, Smode.Altitude))
            {
                checkedSmodeList.SetItemChecked(3, true);
            }
            if (Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, Smode.PowerOutput))
            {
                checkedSmodeList.SetItemChecked(4, true);
            }
            if (Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, Smode.Imperial))
            {
                checkedSmodeList.SetItemChecked(5, true);
            }
        }

        private void UpdateDataGrid()
        {
            dataGridView1.DataSource = _currentExerciseSession;
        }

        private void UpdateGraph()
        {
            if (!zedGraphControl1.Visible)
                zedGraphControl1.Visible = true;

            Grapher.UpdateGraph(ref zedGraphControl1, ref _currentExerciseSession);
        }
        #endregion

    }
}
