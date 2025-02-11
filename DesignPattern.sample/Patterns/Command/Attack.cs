using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Command;

public class Attack : ICommand
{
    private readonly Character _attacker;
    private readonly Character _target;

    public Attack(Character attacker, Character target)
    {
        this._attacker = attacker;
        this._target = target;
    }


    public void Execute()
    {
        _attacker.IncreaseHeal(10);
        _target.DecreaseHeal(10);
    }

    public void Undo()
    {
        _attacker.DecreaseHeal(10);
        _target.IncreaseHeal(10);
    }
}
