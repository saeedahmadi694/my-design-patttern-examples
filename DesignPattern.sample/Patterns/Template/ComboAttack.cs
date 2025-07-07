using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Template;

public abstract class ComboAttack
{
    public void ExecuteCombo()
    {
        StartAnimation();
        if (ShouldPlaySoundEffect()) //hook method
            PlaySoundEffect();
        PerformHits();
        CalculateDamage();
        EndAnimation();
    }

    private void StartAnimation()
    {
        Console.WriteLine("Starting combo animation...");
    }

    private void PlaySoundEffect()
    {
        Console.WriteLine("Playing sound effect: ComboInitiated.wav");
    }

    protected virtual bool ShouldPlaySoundEffect()
    {
        return false;
    }

    protected abstract void PerformHits();

    private void CalculateDamage()
    {
        Console.WriteLine("Calculating total combo damage...");
    }

    private void EndAnimation()
    {
        Console.WriteLine("Ending combo animation...");
    }
}
