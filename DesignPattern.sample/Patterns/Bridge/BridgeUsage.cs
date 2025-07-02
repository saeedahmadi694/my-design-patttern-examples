using DesignPattern.sample.Patterns.Bridge.Enchantments;
using DesignPattern.sample.Patterns.Bridge.Weapons;
using DesignPattern.sample.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Bridge;

public class BridgeUsage
{
    public void Run()
    {
       var swordSton = new Sword(new Ston());
       var sworIce = new Sword(new Ston());
       var fireBow = new Bow(new Fire());

        swordSton.Attack();
        sworIce.Attack();
        fireBow.Attack();
    }
}
