using System;
using OxyPlot;
using OxyPlot.Series;

namespace drawing_graphs
{
    internal class FunсСalculator
    {
        //public double min { get; private set; }
        //public double max { get; private set; }
        public GraphData Data { get; set; }

        public FunсСalculator(GraphData data)
        {
            Data = data;
        }

        public FunсСalculator()
        {
            Data = new GraphData();
        }

        public FunctionSeries PointCalculate()
        {
            var pointSeries = new FunctionSeries();
            //pointSeries.LineStyle = LineStyle.LongDash;
            pointSeries.Points.Add(new DataPoint(Data.StartX, Data.StartY));
            double x = Data.StartX, y = Data.StartY;
            for (int i = 0; i < Data.CountCalculatePoints; i++)
            {
                double tempX = x;
                x += Math.Sin(y);
                y = y + Data.ConstA * tempX + Data.ConstB * Math.Sin(y);
                pointSeries.Points.Add(new DataPoint(y, x));
            }

            return pointSeries;
        }

        public FunctionSeries PointCalculate(GraphData data)
        {
            Data = data;
            return PointCalculate();
        }
    }
}
