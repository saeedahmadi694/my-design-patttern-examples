using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Command;

public class Heal : ICommand
{
    private readonly Character _target;

    public Heal(Character target)
    {
        this._target = target;
    }


    public void Execute()
    {
        _target.IncreaseHeal(10);
    }

    public void Undo()
    {
        _target.DecreaseHeal(10);
    }
}
