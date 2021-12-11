using WpfApplication1;
using System.Diagnostics;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using OxyPlot;
using OxyPlot.Series;
using drawing_graphs.Interfaces;
using drawing_graphs;
using OxyPlot.Axes;

namespace drawing_graphs.ViewModels

{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly FunсСalculator funсСalculator = new FunсСalculator();
        private PlotModel graph { get; set; }
        public PlotModel Model => graph;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Calculate(GraphData data)
        {
            graph.Series.Clear();
            graph.Series.Add(funсСalculator.PointCalculate(data));
            graph.InvalidatePlot(true);
            //graph.AxisTierDistance.TryFormat();
            /* graph.Axes.Clear();
             graph.Axes.Add(new LinearAxis
             {
                 Position = AxisPosition.Left,
                 AbsoluteMaximum = funсСalculator.max,
                 AbsoluteMinimum = funсСalculator.min,
             });
             graph.Axes.Add(new LinearAxis());*/
            Debug.WriteLine("done");
            OnPropertyChanged(nameof(graph));
            //graph.Updated;
        }
        public MainViewModel()
        {
            graph = new PlotModel {Title = "Graph"};
            graph.Series.Add(funсСalculator.PointCalculate());
        }

    }

}