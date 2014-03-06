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
                y_alt[index] = interval.m_altitude;
                y_bpm[index] = interval.m_bpm;
                y_cad[index] = interval.m_cadence;
                y_pow[index] = interval.m_power;
                y_powBalance[index] = interval.m_powerBalance;
                y_speed[index] = interval.m_speed;

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

            // Add curves to myPane object
            LineItem altitudeCurve = myPane.AddCurve("Altitude", altitude, Color.Blue, SymbolType.None);
            LineItem bpmCurve = myPane.AddCurve("Bpm", bpm, Color.Red, SymbolType.None);
            LineItem cadanceCurve = myPane.AddCurve("Cadence", cad, Color.Yellow, SymbolType.None);
            LineItem powerCurve = myPane.AddCurve("Power", pow, Color.SpringGreen, SymbolType.None);
            //LineItem powerBalanceCurve = myPane.AddCurve("Power Balance", powBal, Color.Purple, SymbolType.None);
            LineItem speedCurve = myPane.AddCurve("Speed", speed, Color.RosyBrown, SymbolType.None);

            altitudeCurve.Line.Width = 2.0F;
            bpmCurve.Line.Width = 2.0F;
            cadanceCurve.Line.Width = 2.0F;
            powerCurve.Line.Width = 2.0F;
            //powerBalanceCurve.Line.Width = 2.0F;
            speedCurve.Line.Width = 2.0F;

            myPane.Title.Text = "Test Cycle data plotting";

            // I add all three functions just to be sure it refeshes the plot.   
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
            zedGraphControl.Refresh();
        }
    }
}
