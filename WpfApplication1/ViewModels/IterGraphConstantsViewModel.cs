using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_graphs.ViewModels
{
    class IterGraphConstantsViewModel : INotifyPropertyChanged
    {
        private GraphData data = new GraphData();
        public MainViewModel ParentViewModel;
        private int _delayTime = 3000;
        private double _startA = 1, _endA = 2, _startB = 1, _endB = 2;
        private double _deltaA = 0.5, _deltaB = 0.5;
        private double _currentA = 1, _currentB = 1;
        public bool CanCalculate = true;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void StartCalculate()
        {
            for (double a = _startA; a <= _endA; a += _deltaA)
            {
                for (double b = _startB; b <= _endB; b += _deltaB)
                {
                    if (!CanCalculate)
                    {
                        return;
                    }
                    data.ConstA = _currentA = a;

                    data.ConstB = _currentB = b;
                    OnPropertyChanged(nameof(CurrentA));
                    OnPropertyChanged(nameof(CurrentB));
                    ParentViewModel.Calculate(data);
                    await Task.Delay(_delayTime);
                }
            }

        }
        public string DelayTime
        {
            get => _delayTime.ToString();
            set => _delayTime = int.Parse(value);
        }
        public string StartA
        {
            get => _startA.ToString();
            set
            {
                _startA = MyConvert.StrToDouble(value);
                _currentA = _startA;
            } 
        }

        public string EndA
        {
            get => _endA.ToString();
            set => _endA = MyConvert.StrToDouble(value);
        }
        public string DeltaA
        {
            get => _deltaA.ToString();
            set => _deltaA = MyConvert.StrToDouble(value);
        }

        public string CurrentA
        {
            get => _currentA.ToString();
            set => _currentA = MyConvert.StrToDouble(value);
        } 

        public string StartB
        {
            get => _startB.ToString();
            set
            {
                _startB = MyConvert.StrToDouble(value);
                _currentB = _startB;
            }
        }

        public string EndB
        {
            get => _endB.ToString();
            set => _endB = MyConvert.StrToDouble(value);
        }
        public string DeltaB
        {
            get => _deltaB.ToString();
            set => _deltaB = MyConvert.StrToDouble(value);
        }

        public string CurrentB
        {
            get => _currentB.ToString();
            set => _currentB = MyConvert.StrToDouble(value);
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
