
using DesignPattern.sample.Patterns.ChainOfResponsibility;
using System;

namespace DesignPattern.sample.Patterns.AbstractFactory;

public class GameUIRenderer
{
    private readonly IGameUIFactory _uiFactory;

    public GameUIRenderer(IGameUIFactory uiFactory)
    {
        _uiFactory = uiFactory;
    }

    public void BuildUI()
    {
        var button = _uiFactory.CreateButton();
        var panel = _uiFactory.CreatePanel();
        var slider = _uiFactory.CreateSlider();

        button.Render();
        panel.Show();
        slider.Slide();
    }
}
