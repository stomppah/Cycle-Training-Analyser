using System;
using System.Globalization;
using System.Windows.Forms;
using Analyser.Utilities;
using System.Collections.Generic;

namespace Analyser
{
    public partial class MainForm : Form
    {
        private ExerciseSession _currentExerciseSession = new ExerciseSession();
        private List<Interval> intervals = new List<Interval>();

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

            SetupColumns();

            for (int index = 0; index < _currentExerciseSession.HeartRateList.Count; index++)
            {
                intervals.Add(new Interval()
                {
                    Bpm = _currentExerciseSession.HeartRateList[index], 
                    Speed = FlagSet(Smode.Speed) ? _currentExerciseSession.SpeedList[index] : 0,
                    Cadence = FlagSet(Smode.Cadence) ? _currentExerciseSession.CadenceList[index] : 0,
                    Altitude = FlagSet(Smode.Altitude) ? _currentExerciseSession.AltitudeList[index] : 0,
                    Power = FlagSet(Smode.PowerOutput) ? _currentExerciseSession.PowerList[index] : 0
                });
            }

            dataGridView1.DataSource = intervals;
        }

        private void SetupColumns()
        {
            // Automatically generate the DataGridView columns.
            dataGridView1.AutoGenerateColumns = true;

            //if (!FlagSet(Smode.Speed))
            //{
            //    dataGridView1.Columns.Remove("Speed");
            //}
            //if (!FlagSet(Smode.Cadence))
            //{
            //    dataGridView1.Columns.Remove("Cadence");
            //}
            //if (!FlagSet(Smode.Altitude))
            //{
            //    dataGridView1.Columns.Remove("Altitude");
            //}
            //if (!FlagSet(Smode.PowerOutput))
            //{
            //    dataGridView1.Columns.Remove("Power");
            //}
        }

        private bool FlagSet(Smode smode)
        {
            return Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, smode);
        }

        private void UpdateGraph()
        {
            if (!zedGraphControl1.Visible)
                zedGraphControl1.Visible = true;

            Grapher.UpdateGraph(ref zedGraphControl1, ref _currentExerciseSession);
        }
        #endregion

    }

    class Interval
    {
        public DateTime Time { get; set; }
        public int Bpm { get; set; }
        public int Speed { get; set; }
        public int Cadence { get; set; }
        public int Altitude { get; set; }
        public int Power { get; set; }
    }
}
