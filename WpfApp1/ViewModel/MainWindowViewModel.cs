using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp1.ViewModel;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private List<Tier> _tiers = new();
}
