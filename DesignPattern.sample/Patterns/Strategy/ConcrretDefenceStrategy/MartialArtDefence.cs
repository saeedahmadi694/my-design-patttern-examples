namespace DesignPattern.sample.Patterns.Strategy.ConcrretDefenceStrategy;

public class MartialArtDefence : IDefenceStrategy
{
    public void Defend()
    {
        Console.WriteLine("defence by Martial Art");
    }
}
