using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Memento;
public class GameSaveManager
{
    private List<PlayerStatsMemento> _savedStates = new List<PlayerStatsMemento>();
    private PlayerStats _currentPlayerStats;
    public GameSaveManager(PlayerStats playerStats)
    {
        _currentPlayerStats = playerStats;
    }
    public void SaveGame()
    {
        _savedStates.Add(_currentPlayerStats.SaveState());
        Console.WriteLine("Game saved.");
    }
    public void LoadGame(int index)
    {
        if (index < 0 || index >= _savedStates.Count)
        {
            Console.WriteLine("Invalid save index.");
            return;
        }
        _currentPlayerStats.RestoreState(_savedStates[index]);
        Console.WriteLine($"Game loaded from save index {index}.");
    }
}
