namespace MinimalDataBindingSample.ViewModel;

public sealed class MainWindowViewModelMock : MainWindowViewModel
{
    public MainWindowViewModelMock()
    {
        LabelText = new LabelText { Text = "Hello World" };
    }
}
