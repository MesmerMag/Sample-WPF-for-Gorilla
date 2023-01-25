using System.Threading.Tasks;
using MinimalDataBindingSample.ViewModel;

namespace MinimalDataBindingSample
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var vm = new MainWindowViewModel();
            DataContext = vm;

            // Faking updating the label text after, e.g., an API request:
            Task.Delay(2000).ContinueWith(_ =>
            {
                vm.LabelText = new LabelText { Text = "Aliens!" };
            });
        }
    }
}
