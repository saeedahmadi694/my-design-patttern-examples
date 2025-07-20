using DesignPattern.sample.Patterns.Decorator.Abilities;

namespace DesignPattern.sample.Patterns.Memento;

public class MementoUsage
{
    public void Run()
    {
        var ps = new PlayerStats(50, 30, 10);
        var saveManager = new GameSaveManager(ps);

        saveManager.SaveGame();

        saveManager.LoadGame(1);
    }
}
