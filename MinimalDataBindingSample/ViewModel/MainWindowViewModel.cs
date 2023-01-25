using CommunityToolkit.Mvvm.ComponentModel;

namespace MinimalDataBindingSample.ViewModel;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private LabelText _labelText = new() { Text = "" };
}
