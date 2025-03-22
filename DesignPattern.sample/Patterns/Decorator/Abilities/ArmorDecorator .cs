namespace DesignPattern.sample.Patterns.Decorator.Abilities;

public class ArmorDecorator : Character
{
    public ArmorDecorator(Character character) : base(character)
    {

    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine(" + Equipped with Armor");
    }
}
