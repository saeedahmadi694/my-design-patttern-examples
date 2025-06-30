using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Strategy.ConcrretAttackStrategy;

public class BowAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("attack by Bow");
    }
}
