
using DesignPattern.sample.Patterns.ChainOfResponsibility;
using System;

namespace DesignPattern.sample.Patterns.AbstractFactory;



public interface IGameUIFactory
{
    IButton CreateButton();
    IPanel CreatePanel();
    ISlider CreateSlider();
}