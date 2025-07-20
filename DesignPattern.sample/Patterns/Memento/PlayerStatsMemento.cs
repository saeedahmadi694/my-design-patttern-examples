using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Memento;
public class PlayerStatsMemento
{
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Level { get; set; }
    public PlayerStatsMemento(int health, int mana, int level)
    {
        Health = health;
        Mana = mana;
        Level = level;
    }
}
