using DesignPattern.sample.Patterns.Decorator.Abilities;

namespace DesignPattern.sample.Patterns.AbstractFactory;

public class AbstractFactoryUsage
{
    public void Run()
    {
        IGameUIFactory uiFactory = new PCUIFactory();
        var uiRenderer = new GameUIRenderer(uiFactory);
        uiRenderer.BuildUI();
    }
}
