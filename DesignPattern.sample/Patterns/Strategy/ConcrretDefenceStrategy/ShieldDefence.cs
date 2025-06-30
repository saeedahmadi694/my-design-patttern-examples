using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Strategy.ConcrretDefenceStrategy;

public class ShieldDefence : IDefenceStrategy
{
    public void Defend()
    {
        Console.WriteLine("defence by shield");
    }
}
