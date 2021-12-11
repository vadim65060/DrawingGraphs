using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using drawing_graphs.Interfaces;

namespace drawing_graphs.ViewModels
{
    internal class GraphConstantsViewModel
    {
        private GraphData data = new GraphData();
        public MainViewModel ParentViewModel;


        public void StartCalculate()
        {
            ParentViewModel.Calculate(data);
        }

        public string A
        {
            get => data.ConstA.ToString();
            set => data.ConstA = MyConvert.StrToDouble(value);
        }

        public string B
        {
            get => data.ConstB.ToString();
            set => data.ConstB = MyConvert.StrToDouble(value);
        }

        public string StartX
        {
            get => data.StartX.ToString();
            set => data.StartX = MyConvert.StrToDouble(value);
        }

        public string StartY
        {
            get => data.StartY.ToString();
            set => data.StartY = MyConvert.StrToDouble(value);
        }

        public string CountPoints
        {
            get => data.CountCalculatePoints.ToString();
            set => data.CountCalculatePoints = int.Parse(value);

        }
    }
}
