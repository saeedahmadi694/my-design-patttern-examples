using DesignPattern.sample.Patterns.ChainOfResponsibility.Damages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.ChainOfResponsibility;

public class ChainOfResponsibilityUsage
{
    public void Run()
    {
        var armorHandler = new ArmorHandler();
        var shieldHandler = new ShieldHandler();
        var magicResistanceHandler = new MagicResistanceHandler();

        armorHandler.SetNext(shieldHandler.SetNext(magicResistanceHandler));

        int damage = 50;
        string damageType = "Magic";

        Console.WriteLine($"Player takes {damage} {damageType} damage!");
        armorHandler.HandleRequest(ref damage, damageType);
        Console.WriteLine($"Final damage taken: {damage}");
    }
}
