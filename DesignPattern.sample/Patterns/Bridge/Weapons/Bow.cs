using DesignPattern.sample.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Bridge.Weapons;

public class Bow : Weapon
{
    public Bow(IEnchantment enchantment) : base(enchantment)
    {
    }
    public override void Attack()
    {
        Console.WriteLine("The bow is shooting an arrow");
        _enchantment.Apply();
    }
}
