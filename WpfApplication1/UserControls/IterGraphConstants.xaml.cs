using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using drawing_graphs.ViewModels;

namespace drawing_graphs.UserControls
{
    /// <summary>
    /// Логика взаимодействия для IterGraphConstants.xaml
    /// </summary>
    public partial class IterGraphConstants : UserControl
    {
        private readonly IterGraphConstantsViewModel _viewModel;
        public IterGraphConstants()
        {
            InitializeComponent();
            _viewModel = new IterGraphConstantsViewModel();
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.StartCalculate();
        }
        public void SetParentModel(MainViewModel viewModel)
        {
            _viewModel.ParentViewModel = viewModel;
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            _viewModel.CanCalculate = !_viewModel.CanCalculate;
        }
    }
}
