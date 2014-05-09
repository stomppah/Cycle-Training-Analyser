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
            if (Extensions.IsFlagSet(_currentExerciseSession.CurrentSMode, Smode.Power))
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

            

            dataGridView1.AutoGenerateColumns = true;

            for (int index = 0; index < _currentExerciseSession.HeartRateList.Count; index++)
            {
                intervals.Add(new Interval()
                {
                    Bpm = _currentExerciseSession.HeartRateList[index].ToString(CultureInfo.InvariantCulture),
                    Speed = FlagSet(Smode.Speed) ? _currentExerciseSession.SpeedList[index].ToString(CultureInfo.InvariantCulture) : "-",
                    Cadence = FlagSet(Smode.Cadence) ? _currentExerciseSession.CadenceList[index].ToString(CultureInfo.InvariantCulture) : "-",
                    Altitude = FlagSet(Smode.Altitude) ? _currentExerciseSession.AltitudeList[index].ToString(CultureInfo.InvariantCulture) : "-",
                    Power = FlagSet(Smode.Power) ? _currentExerciseSession.PowerList[index].ToString(CultureInfo.InvariantCulture) : "-"
                });
            }
            
            dataGridView1.DataSource = intervals;

            SetupColumns();
        }

        private void SetupColumns()
        {
            var dataGridViewColumn = dataGridView1.Columns["Speed"];
            if (dataGridViewColumn != null) 
                dataGridViewColumn.Visible = FlagSet(Smode.Speed);
            
            var gridViewColumn = dataGridView1.Columns["Cadence"];
            if (gridViewColumn != null)
                gridViewColumn.Visible = FlagSet(Smode.Cadence);
            
            var viewColumn = dataGridView1.Columns["Altitude"];
            if (viewColumn != null)
                viewColumn.Visible = FlagSet(Smode.Altitude);
            
            var column = dataGridView1.Columns["Power"];
            if (column != null) 
                column.Visible = FlagSet(Smode.Power);

            // Automatically resize the visible rows.
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCells;

            // Set the DataGridView control's border.
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
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
        public string Bpm { get; set; }
        public string Speed { get; set; }
        public string Cadence { get; set; }
        public string Altitude { get; set; }
        public string Power { get; set; }
    }
}
