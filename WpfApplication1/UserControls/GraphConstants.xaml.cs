using System.Windows;
using System.Windows.Controls;
using drawing_graphs.ViewModels;

namespace drawing_graphs
{
    /// <summary>
    /// Логика взаимодействия для GraphConstants.xaml
    /// </summary>
    public partial class GraphConstants : UserControl
    {
        private readonly GraphConstantsViewModel _viewModel;

        public GraphConstants()
        {
            InitializeComponent();
            _viewModel = new GraphConstantsViewModel();
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
    }
}
