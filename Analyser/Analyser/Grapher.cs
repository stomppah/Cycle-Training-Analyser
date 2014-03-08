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
        internal static void UpdateGraph(ref ZedGraph.ZedGraphControl zedGraphControl, ref SessionDataList sessionDataList)
        {
            // Lets generate sine and cosine wave
            double[] x = new double[sessionDataList.Count];
            double[] y_alt = new double[sessionDataList.Count];
            double[] y_bpm = new double[sessionDataList.Count];
            double[] y_speed = new double[sessionDataList.Count];
            double[] y_pow = new double[sessionDataList.Count];
            double[] y_cad = new double[sessionDataList.Count];
            double[] y_powBalance = new double[sessionDataList.Count];

            int index = 0;

            foreach (var interval in sessionDataList)
            {
                x[index] = index;
                y_alt[index] = interval.Altitude;
                y_bpm[index] = interval.Bpm;
                y_cad[index] = interval.Cadence;
                y_pow[index] = interval.Power;
                y_powBalance[index] = interval.PowerBalance;
                y_speed[index] = interval.Speed;

                index++;
            }


            // This is to remove all plots
            zedGraphControl.GraphPane.CurveList.Clear();

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphControl.GraphPane;

            // PointPairList holds the data for plotting, X and Y arrays 
            PointPairList altitude = new PointPairList(x, y_alt);
            PointPairList bpm = new PointPairList(x, y_bpm);
            PointPairList cad = new PointPairList(x, y_cad);
            PointPairList pow = new PointPairList(x, y_pow);
            PointPairList powBal = new PointPairList(x, y_powBalance);
            PointPairList speed = new PointPairList(x, y_speed);

            LineItem bpmCurve = myPane.AddCurve("Bpm", bpm, Color.Red, SymbolType.None);
            LineItem speedCurve = Extensions.IsFlagSet(sessionDataList.CurrentSMode, Smode.Speed)
                ? myPane.AddCurve("Speed", speed, Color.RosyBrown, SymbolType.None) : null;
            LineItem cadanceCurve = Extensions.IsFlagSet(sessionDataList.CurrentSMode, Smode.Cadence)
                ? myPane.AddCurve("Cadence", cad, Color.Yellow, SymbolType.None) : null;
            LineItem powerCurve = Extensions.IsFlagSet(sessionDataList.CurrentSMode, Smode.PowerOutput)
                ? myPane.AddCurve("Power", pow, Color.SpringGreen, SymbolType.None) : null;
            LineItem altitudeCurve = Extensions.IsFlagSet(sessionDataList.CurrentSMode, Smode.Altitude)
                ? (myPane.AddCurve("Altitude", altitude, Color.Blue, SymbolType.None)) : null;

           
            bpmCurve.Line.Width = 3.0F;
            if (speedCurve != null)
                speedCurve.Line.Width = 2.0F;
            if (altitudeCurve != null)
                altitudeCurve.Line.Width = 2.0F;
            if (cadanceCurve != null)
                cadanceCurve.Line.Width = 2.0F;
            if (powerCurve != null)
                powerCurve.Line.Width = 2.0F;

            myPane.Title.Text = "Test Cycle data plotting";

            // I add all three functions just to be sure it refeshes the plot.   
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
            zedGraphControl.Refresh();
        }
    }
}
