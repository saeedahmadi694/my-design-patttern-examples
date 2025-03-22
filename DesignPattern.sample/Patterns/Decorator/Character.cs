namespace DesignPattern.sample.Patterns.Decorator;

public class Character
{
    public string Name { get; set; }
    public int Heal { get; set; }

    public Character(string name, int heal)
    {
        Name = name;
        Heal = heal;
    }
    public Character(Character character)
    {
        Name = character.Name;
        Heal = character.Heal;
    }

    public virtual void Display()
    {
        Console.WriteLine("Base character");
    }
}
