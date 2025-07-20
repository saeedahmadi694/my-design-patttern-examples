using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Memento;
public class PlayerStats
{
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Level { get; set; }
    public PlayerStats(int health, int mana, int level)
    {
        Health = health;
        Mana = mana;
        Level = level;
    }
    public PlayerStatsMemento SaveState()
    {
        return new PlayerStatsMemento(Health, Mana, Level);
    }
    public void RestoreState(PlayerStatsMemento memento)
    {
        Health = memento.Health;
        Mana = memento.Mana;
        Level = memento.Level;
    }
}
