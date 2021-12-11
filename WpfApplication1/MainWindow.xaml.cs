using drawing_graphs.ViewModels;

namespace WpfApplication1
{
    using System.Windows;

    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
            ConstantsBox.SetParentModel(_viewModel);
            IterConstantBox.SetParentModel(_viewModel);
        }
    }
}