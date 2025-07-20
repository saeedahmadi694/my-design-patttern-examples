using DesignPattern.sample.Patterns.Decorator.Abilities;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPattern.sample.Patterns.Prototype;

public class PrototypeUsage
{
    public void Run()
    {
        ICharacter warriorPrototype = new Warrior(100, 50, "Sword");
        ICharacter clonedWarrior = warriorPrototype.Clone();
        clonedWarrior.Display();
    }
}
