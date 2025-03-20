using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.ChainOfResponsibility;

public class Character
{
    public string Name { get; set; }
    public int Heal { get; set; }

    public Character(string name, int heal)
    {
        Name = name;
        Heal = heal;
    }
}
