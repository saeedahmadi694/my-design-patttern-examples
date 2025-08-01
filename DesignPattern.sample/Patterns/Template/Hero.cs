﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Template;

public class Hero : ComboAttack
{
    public string Title { get; set; }
    public int Helth { get; set; }
    public int AttackDamage { get; set; }
    protected override void PerformHits()
    {
        Console.WriteLine($"Hero performs: attack damage : {AttackDamage}");
    }
    protected override bool ShouldPlaySoundEffect()
    {
        return true;
    }
}
