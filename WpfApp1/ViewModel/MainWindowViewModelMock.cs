using System.Collections.Generic;

namespace WpfApp1.ViewModel;

public sealed class MainWindowViewModelMock : MainWindowViewModel
{
    public MainWindowViewModelMock()
    {
        Tiers = new List<Tier>
        {
            new()
            {
                TierNum = "Tier 1",
                Servers = new List<Server>
                {
                    new()
                    {
                        Name = "Fort Aspenwood",
                        Rank = "1",
                        VictoryPoints = "193",
                        WarScore = "31"
                    },
                    new()
                    {
                        Name = "Sea of Sorrows",
                        Rank = "2",
                        VictoryPoints = "161",
                        WarScore = "42"
                    },
                }
            },
            new()
            {
                TierNum = "Tier 2",
                Servers = new List<Server>
                {
                    new()
                    {
                        Name = "Jade Quarry",
                        Rank = "1",
                        VictoryPoints = "203",
                        WarScore = "3131"
                    },
                    new()
                    {
                        Name = "Darkhaven",
                        Rank = "2",
                        VictoryPoints = "188",
                        WarScore = "5001"
                    },
                }
            }
        };
    }
}
