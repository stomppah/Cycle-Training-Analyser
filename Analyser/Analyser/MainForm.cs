﻿using System;
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
                var interval = new Interval();
                interval.Time = _currentExerciseSession.TimeIntervalList[index];
                interval.Bpm = _currentExerciseSession.HeartRateList[index].ToString(CultureInfo.InvariantCulture);
                interval.Speed = FlagSet(Smode.Speed)
                    ? _currentExerciseSession.SpeedList[index].ToString(CultureInfo.InvariantCulture)
                    : "-";
                interval.Cadence = FlagSet(Smode.Cadence)
                    ? _currentExerciseSession.CadenceList[index].ToString(CultureInfo.InvariantCulture)
                    : "-";
                interval.Altitude = FlagSet(Smode.Altitude)
                    ? _currentExerciseSession.AltitudeList[index].ToString(CultureInfo.InvariantCulture)
                    : "-";
                interval.Power = FlagSet(Smode.Power)
                    ? _currentExerciseSession.PowerList[index].ToString(CultureInfo.InvariantCulture)
                    : "-";
                interval.PowerBalance = FlagSet(Smode.PowerBalance)
                    ? _currentExerciseSession.PowerBalanceList[index].ToString(CultureInfo.InvariantCulture)
                    : "-";
                intervals.Add(interval);
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

    }

}
