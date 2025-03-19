using DesignPattern.sample.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Bridge.Weapons;

public class Axe : Weapon
{
    public Axe(IEnchantment enchantment) : base(enchantment)
    {
    }
    public override void Attack()
    {
        Console.WriteLine("The axe is swinging");
        _enchantment.Apply();
    }
}
