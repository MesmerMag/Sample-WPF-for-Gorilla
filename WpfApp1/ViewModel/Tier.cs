using System.Collections.Generic;

namespace WpfApp1.ViewModel;

public class Tier
{
    public required string TierNum { get; init; }
    public required List<Server> Servers { get; init; }
}
