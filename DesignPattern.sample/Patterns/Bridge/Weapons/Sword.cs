using DesignPattern.sample.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Bridge.Weapons;

public class Sword : Weapon
{
    public Sword(IEnchantment enchantment) : base(enchantment)
    {
    }
    public override void Attack()
    {
        Console.WriteLine("The sword is swinging");
        _enchantment.Apply();
    }
}