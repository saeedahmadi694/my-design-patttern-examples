using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Proxy;

public class Player
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Level { get; set; }
    public int Money { get; set; }

    public Player(string firstName, string lastName, int level, int money)
    {
        FirstName = firstName;
        LastName = lastName;
        Level = level;
        Money = money;
    }

    public bool HasEnoughResources()
    {
        return Money >= 100;
    }
}
