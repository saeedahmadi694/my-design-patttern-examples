
namespace DesignPattern.sample.Patterns.Decorator.Abilities;

public class FireEnchantmentDecorator : Character
{
    public FireEnchantmentDecorator(Character character) : base(character)
    {

    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine(" + Weapon Enchanted with Fire");
    }
}