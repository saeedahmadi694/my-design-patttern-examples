
using DesignPattern.sample.Patterns.ChainOfResponsibility;
using System;

namespace DesignPattern.sample.Patterns.AbstractFactory;


public class PCUIFactory : IGameUIFactory
{
    public IButton CreateButton() => new PCButton();
    public IPanel CreatePanel() => new PCPanel();
    public ISlider CreateSlider() => new PCSlider();
}
