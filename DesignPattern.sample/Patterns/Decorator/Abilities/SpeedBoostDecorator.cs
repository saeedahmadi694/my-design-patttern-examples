namespace DesignPattern.sample.Patterns.Decorator.Abilities;

public class SpeedBoostDecorator : Character
{
    public SpeedBoostDecorator(Character character) : base(character)
    {

    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine(" + Speed Boost Active");
    }
}