using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Command;

public class CommandUsage
{
    public void Run()
    {
        var enemy = new Character("enemy", 500);
        var hero = new Character("hero", 200);

        var attack1Command = new Attack(hero, enemy);
        var attack2Command = new Attack(hero, enemy);
        var attack3Command = new Attack(enemy, hero);
        var attack4Command = new Attack(hero, enemy);

        var invoker = new InvokerCommand();

        invoker.ExecuteCommand(attack1Command);
        invoker.ExecuteCommand(attack2Command);
        invoker.ExecuteCommand(attack3Command);
        invoker.ExecuteCommand(attack4Command);


        var heal1Command = new Heal(hero);
        var heal2Command = new Heal(hero);

        invoker.ExecuteCommand(heal1Command);
        invoker.ExecuteCommand(heal2Command);


        invoker.UndoLastCommand();
    }
}
