using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Factory;

public static class WeaponFactory
{
    public static IWeapon CreateWeapon(string classType)
    {
        return classType switch
        {
            "Warrior" => new Sword(),
            "Archer" => new Bow(),
            "Mage" => new Staff(),
            _ => throw new ArgumentException("Invalid class type")
        };
    }
}
