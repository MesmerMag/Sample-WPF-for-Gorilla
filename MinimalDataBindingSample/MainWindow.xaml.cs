using MinimalDataBindingSample.ViewModel;

namespace MinimalDataBindingSample
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
