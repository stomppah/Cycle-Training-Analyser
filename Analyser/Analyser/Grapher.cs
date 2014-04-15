using Analyser.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Analyser
{
    internal class Grapher
    {
        // GraphPane object holds one or more 5Curve objects (or plots)
        internal static GraphPane MyPane;
        internal static double[] XTime, YAltitude, YBpm, YSpeed, YPower, YCadance, YPowerBalance;
        internal static SessionDataList SessionDataList;
        internal static int ListCount;

        internal static PointPairList AltitudePointPairList,
            BpmPointPairList,
            CadencePointPairList,
            PowerPointPairList,
            SpeedPointPairList,
            PowerBalancePointPairList;

        internal static void UpdateGraph(ref ZedGraph.ZedGraphControl zedGraphControl, ref SessionDataList sessionDataList)
        {
            // Update all fields from incoming data
            SessionDataList = sessionDataList;
            ListCount = SessionDataList.Count;
            MyPane = zedGraphControl.GraphPane;

            ResetAndUpdateIntervalData();

            RemovePreviousPlots();

            SetupGraphAxes();

            ResetPointPairListsFromIntervalData();

            DrawDataToGraph();

            // I add all three functions just to be sure it refeshes the plot.   
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
            zedGraphControl.Refresh();
        }

        private static void DrawDataToGraph()
        {
            var bpmCurve = MyPane.AddCurve("Bpm", BpmPointPairList, Color.Red, SymbolType.None);
            var speedCurve = Extensions.IsFlagSet(SessionDataList.CurrentSMode, Smode.Speed)
                ? MyPane.AddCurve("Speed", SpeedPointPairList, Color.RosyBrown, SymbolType.None)
                : null;
            var cadanceCurve = Extensions.IsFlagSet(SessionDataList.CurrentSMode, Smode.Cadence)
                ? MyPane.AddCurve("Cadence", CadencePointPairList, Color.Yellow, SymbolType.None)
                : null;
            var powerCurve = Extensions.IsFlagSet(SessionDataList.CurrentSMode, Smode.PowerOutput)
                ? MyPane.AddCurve("Power", PowerPointPairList, Color.SpringGreen, SymbolType.None)
                : null;
            var altitudeCurve = Extensions.IsFlagSet(SessionDataList.CurrentSMode, Smode.Altitude)
                ? (MyPane.AddCurve("Altitude", AltitudePointPairList, Color.Blue, SymbolType.None))
                : null;

            bpmCurve.Line.Width = 3.0F;
            if (speedCurve != null)
                speedCurve.Line.Width = 2.0F;
            if (altitudeCurve != null)
                altitudeCurve.Line.Width = 2.0F;
            if (cadanceCurve != null)
                cadanceCurve.Line.Width = 2.0F;
            if (powerCurve != null)
                powerCurve.Line.Width = 2.0F;
        }

        private static void ResetPointPairListsFromIntervalData()
        {
            // These lists hold the data for plotting X and Y arrays 
            AltitudePointPairList = new PointPairList(XTime, YAltitude);
            BpmPointPairList = new PointPairList(XTime, YBpm);
            CadencePointPairList = new PointPairList(XTime, YCadance);
            PowerPointPairList = new PointPairList(XTime, YPower);
            PowerBalancePointPairList = new PointPairList(XTime, YPowerBalance);
            SpeedPointPairList = new PointPairList(XTime, YSpeed);
        }

        private static void RemovePreviousPlots()
        {
            MyPane.CurveList.Clear();
        }

        private static void SetupGraphAxes()
        {
            MyPane.Title.Text = "Test Cycle data plotting";

            // X Axis
            MyPane.XAxis.Title.Text = "Time (seconds)";
            MyPane.XAxis.Scale.Format = "HH:mm:ss.fff";
            MyPane.XAxis.Type = AxisType.Date;

            // Y Axis
            MyPane.YAxis.Title.Text = "Some Units Here";
        }

        private static void ResetAndUpdateIntervalData()
        {
            XTime = new double[ListCount];
            YAltitude = new double[ListCount];
            YBpm = new double[ListCount];
            YSpeed = new double[ListCount];
            YPower = new double[ListCount];
            YCadance = new double[ListCount];
            YPowerBalance = new double[ListCount];

            var index = 0;

            foreach (var interval in SessionDataList)
            {
                XTime[index] = index;
                YAltitude[index] = interval.Altitude;
                YBpm[index] = interval.Bpm;
                YCadance[index] = interval.Cadence;
                YPower[index] = interval.Power;
                YPowerBalance[index] = interval.PowerBalance;
                YSpeed[index] = interval.Speed;

                index++;
            }
        }
    }
}
