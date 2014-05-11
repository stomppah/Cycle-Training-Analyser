using System;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Analyser
{
    public partial class MainForm : Form
    {
        private ExerciseSession _currentExerciseSession = new ExerciseSession();
        private readonly List<ExerciseSessionInterval> _intervals = new List<ExerciseSessionInterval>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentExerciseSession = FileManager.LoadFile(OpenFileDialog);
            UpdateGui();
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
            dateLabel.Text = _currentExerciseSession.Date.ToLongDateString();
            timeLabel.Text = _currentExerciseSession.StartTime.ToLongTimeString();
            durationLabel.Text = _currentExerciseSession.Length.ToLongTimeString();

            averageHeartRateLabel.Text = _currentExerciseSession.AverageBpm.ToString(CultureInfo.InvariantCulture) + " bpm";
            maxHeartRateLabel.Text = _currentExerciseSession.MaxBpm.ToString(CultureInfo.InvariantCulture) +" bpm";
            minHeartRateLabel.Text = _currentExerciseSession.MinBpm.ToString(CultureInfo.InvariantCulture) + " bpm";

            averageSpeedLabel.Text = _currentExerciseSession.AverageSpeed.ToString(CultureInfo.InvariantCulture) + " km/h";
            maxSpeedLabel.Text = _currentExerciseSession.MaxSpeed.ToString(CultureInfo.InvariantCulture) + " km/h";

            averageAltitudeLabel.Text = _currentExerciseSession.AverageAltitude.ToString(CultureInfo.InvariantCulture) + " m";
            
            averagePowerLabel.Text = _currentExerciseSession.AveragePower.ToString(CultureInfo.InvariantCulture) + " Watts";
            maxPowerLabel.Text = _currentExerciseSession.MaxPower.ToString(CultureInfo.InvariantCulture) + " Watts";
        }

        private void UpdateRecordedStats()
        {
            if (FlagSet(Smode.Speed))
            {
                checkedSmodeList.SetItemChecked(0, true);
            }
            if (FlagSet(Smode.Cadence))
            {
                checkedSmodeList.SetItemChecked(1, true);
            }
            if (FlagSet(Smode.Altitude))
            {
                checkedSmodeList.SetItemChecked(2, true);
            }
            if (FlagSet(Smode.Power))
            {
                checkedSmodeList.SetItemChecked(3, true);
            }
            if (FlagSet(Smode.Imperial))
            {
                checkedSmodeList.SetItemChecked(4, true);
            }
        }

        private void UpdateDataGrid()
        {
            dataGridView1.AutoGenerateColumns = true;

            for (var index = 0; index < _currentExerciseSession.HeartRateList.Count; index++)
            {
                var interval = new ExerciseSessionInterval
                {
                    Time = _currentExerciseSession.TimeIntervalList[index],
                    Bpm = _currentExerciseSession.HeartRateList[index],
                    Speed = FlagSet(Smode.Speed) ? _currentExerciseSession.SpeedList[index] : 0,
                    Cadence = FlagSet(Smode.Cadence) ? _currentExerciseSession.CadenceList[index] : 0,
                    Altitude = FlagSet(Smode.Altitude) ? _currentExerciseSession.AltitudeList[index] : 0,
                    Power = FlagSet(Smode.Power) ? _currentExerciseSession.PowerList[index] : 0,
                    PowerBalance = FlagSet(Smode.PowerBalance) ? _currentExerciseSession.PowerBalanceList[index] : 0
                };
                _intervals.Add(interval);
            }
            
            dataGridView1.DataSource = _intervals;

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

            var balanceColumn = dataGridView1.Columns["PowerBalance"];
            if (balanceColumn != null)
                balanceColumn.Visible = FlagSet(Smode.PowerBalance);

            // Automatically resize the visible columns.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void exerciseDataPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }

}
