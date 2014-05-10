using System;
using System.Drawing;
using ZedGraph;

namespace Analyser
{
    public class Grapher
    {
        //// GraphPane object holds one or more curve objects (or plots)
        private static GraphPane _myPane;
        private static ExerciseSession _exerciseSession;

        private static readonly PointPairList AltitudePlotList = new PointPairList();
        private static readonly PointPairList HrPlotList = new PointPairList();
        private static readonly PointPairList CadencePlotList = new PointPairList();
        private static readonly PointPairList PowerPlotList = new PointPairList();
        private static readonly PointPairList SpeedPlotList = new PointPairList();
        private static readonly PointPairList PowerBalancePlotList = new PointPairList();

        private static bool _setupComplete = false;

        public static void UpdateGraph(ref ZedGraphControl zedGraphControl, ref ExerciseSession exerciseSession)
        {
            if (zedGraphControl == null) throw new ArgumentNullException("zedGraphControl");

            // Update all fields from incoming data
            _exerciseSession = exerciseSession;
            _myPane = zedGraphControl.GraphPane;

            ResetAndRegenerateLists();

            RemovePreviousPlots();

            if (!_setupComplete)
                SetupGraphAxes();

            // I add all three functions just to be sure it refeshes the plot.   
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
            zedGraphControl.Refresh();
        }

        private static void ResetAndRegenerateLists()
        {
            #region Reset Lists
            HrPlotList.Clear();
            SpeedPlotList.Clear();
            CadencePlotList.Clear();
            AltitudePlotList.Clear();
            PowerPlotList.Clear();
            PowerBalancePlotList.Clear();
            #endregion

            #region Regenerate Lists
            for (var index = 0; index < _exerciseSession.TimeIntervalList.Count; index++)
            {
                var time = _exerciseSession.TimeIntervalList[index];
                HrPlotList.Add(time, _exerciseSession.HeartRateList[index]);
                
                if (Extensions.IsFlagSet(_exerciseSession.CurrentSMode, Smode.Speed)) SpeedPlotList.Add(time, _exerciseSession.SpeedList[index]);
                if (Extensions.IsFlagSet(_exerciseSession.CurrentSMode, Smode.Cadence)) CadencePlotList.Add(time, _exerciseSession.CadenceList[index]);
                if (Extensions.IsFlagSet(_exerciseSession.CurrentSMode, Smode.Altitude)) AltitudePlotList.Add(time, _exerciseSession.AltitudeList[index]);
                if (Extensions.IsFlagSet(_exerciseSession.CurrentSMode, Smode.Power)) PowerPlotList.Add(time, _exerciseSession.PowerList[index]);
                if (Extensions.IsFlagSet(_exerciseSession.CurrentSMode, Smode.PowerBalance)) PowerBalancePlotList.Add(time, _exerciseSession.PowerBalanceList[index]);
            }
            #endregion
        }

        private static void RemovePreviousPlots()
        {
            _myPane.CurveList.Clear();
        }

        private static void SetupGraphAxes()
        {
            // Set the titles and axis labels
            _myPane.Title.Text = "Demonstration of Multi Y Graph";
            _myPane.XAxis.Title.Text = "Time";
            _myPane.YAxis.Title.Text = "HR [bpm]";
            _myPane.Y2Axis.Title.Text = "Speed [m/s]";

            // Create a second Y Axis, green
            YAxis yAxis3 = new YAxis("Altitude [m]");
            _myPane.YAxisList.Add(yAxis3);
            yAxis3.Scale.FontSpec.FontColor = Color.Green;
            yAxis3.Title.FontSpec.FontColor = Color.Green;
            yAxis3.Color = Color.Green;
            // turn off the opposite tics so the Y2 tics don't show up on the Y axis
            //yAxis3.IsInsideTic = false;
            //yAxis3.IsMinorInsideTic = false;
            //yAxis3.IsOppositeTic = false;
            //yAxis3.IsMinorOppositeTic = false;
            // Align the Y2 axis labels so they are flush to the axis
            yAxis3.Scale.Align = AlignP.Inside;

            Y2Axis yAxis4 = new Y2Axis("Cadence [rpm]");
            yAxis4.IsVisible = true;
            _myPane.Y2AxisList.Add(yAxis4);
            // turn off the opposite tics so the Y2 tics don't show up on the Y axis
            //yAxis4.IsInsideTic = false;
            //yAxis4.IsMinorInsideTic = false;
            //yAxis4.IsOppositeTic = false;
            //yAxis4.IsMinorOppositeTic = false;
            // Align the Y2 axis labels so they are flush to the axis
            yAxis4.Scale.Align = AlignP.Inside;
            yAxis4.Type = AxisType.Log;
            //yAxis4.Min = 100;

            // Fill the axis background with a gradient
            _myPane.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);

            _setupComplete = true;
            GenerateExample();
        }

        private static void GenerateExample()
        {
            // Generate a red curve with diamond symbols, and "Velocity" in the legend
            var myCurve = _myPane.AddCurve("HR",
              HrPlotList, Color.Red, SymbolType.HDash);
            // Fill the symbols with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Generate a blue curve with circle symbols, and "Acceleration" in the legend
            myCurve = _myPane.AddCurve("Speed",
               SpeedPlotList, Color.Blue, SymbolType.HDash);
            // Fill the symbols with white
            myCurve.Symbol.Fill = new Fill(Color.White);
            // Associate this curve with the Y2 axis
            myCurve.IsY2Axis = true;

            // Generate a green curve with square symbols, and "Distance" in the legend
            myCurve = _myPane.AddCurve("Altitude",
               AltitudePlotList, Color.Green, SymbolType.None);
            // Fill the symbols with white
            myCurve.Symbol.Fill = new Fill(Color.White);
            // Associate this curve with the second Y axis
            myCurve.YAxisIndex = 1;

            // Generate a Black curve with triangle symbols, and "Energy" in the legend
            myCurve = _myPane.AddCurve("Cadence",
               CadencePlotList, Color.Black, SymbolType.Triangle);
            // Fill the symbols with white
            myCurve.Symbol.Fill = new Fill(Color.White);
            // Associate this curve with the Y2 axis
            myCurve.IsY2Axis = true;
            // Associate this curve with the second Y2 axis
            myCurve.YAxisIndex = 1;

            // Show the x axis grid
            _myPane.XAxis.IsVisible = true; //IsShowGrid = true;

            // Make the Y axis scale red
            _myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            _myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            //myPane.YAxis.IsOppositeTic = false;
            //myPane.YAxis.IsMinorOppositeTic = false;
            // Don't display the Y zero line
            //myPane.YAxis.IsZeroLine = false;
            // Align the Y axis labels so they are flush to the axis
            _myPane.YAxis.Scale.Align = AlignP.Inside;
            //myPane.YAxis.Max = 100;

            // Enable the Y2 axis display
            _myPane.Y2Axis.IsVisible = true;
            // Make the Y2 axis scale blue
            _myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            _myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;
            // turn off the opposite tics so the Y2 tics don't show up on the Y axis
            //myPane.Y2Axis.IsOppositeTic = false;
            //myPane.Y2Axis.IsMinorOppositeTic = false;
            // Display the Y2 axis grid lines
            //myPane.Y2Axis.IsShowGrid = true;
            // Align the Y2 axis labels so they are flush to the axis
            _myPane.Y2Axis.Scale.Align = AlignP.Inside;
            //myPane.Y2Axis.Min = 1.5;
            //myPane.Y2Axis.Max = 3;

            //myPane.AxisChange( CreateGraphics() );
        }
    }
}
