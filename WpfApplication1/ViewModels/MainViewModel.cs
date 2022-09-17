using System.Diagnostics;
using System.ComponentModel;
using OxyPlot;

namespace drawing_graphs.ViewModels

{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly FunсСalculator _funсСalculator = new();
        private PlotModel Graph { get; init; }
        public PlotModel Model => Graph;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }

        public void Calculate(GraphData data)
        {
            Graph.Series.Clear();
            Graph.Series.Add(_funсСalculator.PointCalculate(data));
            Graph.InvalidatePlot(true);
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
            OnPropertyChanged(nameof(Graph));
            //graph.Updated;
        }
        public MainViewModel()
        {
            Graph = new PlotModel {Title = "Graph"};
            Graph.Series.Add(_funсСalculator.PointCalculate());
        }

    }

}