using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Command;

public class Character
{
    public string Name { get; protected set; }
    public int Heal { get; set; }

    public Character(string name, int heal)
    {
        Name = name;
        Heal = heal;
    }

    public Character IncreaseHeal(int take)
    {

        Heal += take;
        return this;
    }

    public Character DecreaseHeal(int take)
    {

        Heal += take;
        return this;
    }
}
