using DesignPattern.sample.Patterns.Decorator.Abilities;

namespace DesignPattern.sample.Patterns.Singleton;

public class SingletonUsage
{
    public void Run()
    {
        GameSettingsManager.Instance.Language = "fa";
        Console.WriteLine("Volume: " + GameSettingsManager.Instance.Volume);
    }
}
