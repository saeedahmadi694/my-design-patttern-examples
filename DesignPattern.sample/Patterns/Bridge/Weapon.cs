using DesignPattern.sample.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Bridge;

public abstract class Weapon
{
    protected readonly IEnchantment _enchantment;

    protected Weapon(IEnchantment enchantment)
    {
        _enchantment = enchantment;
    }

    public abstract void Attack();
}
