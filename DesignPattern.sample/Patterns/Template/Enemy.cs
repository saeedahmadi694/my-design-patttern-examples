using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Template;

public class Enemy : ComboAttack
{
    public string Title { get; set; } = string.Empty;
    public int Helth { get; set; }
    public int AttackDamage { get; set; }

    protected override void PerformHits()
    {
        Console.WriteLine($"Enemy performs: attack damage : {AttackDamage}");
    }
    protected override bool ShouldPlaySoundEffect()
    {
        return false;
    }
}
