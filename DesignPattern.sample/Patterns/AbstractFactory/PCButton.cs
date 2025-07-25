
using DesignPattern.sample.Patterns.ChainOfResponsibility;
using System;

namespace DesignPattern.sample.Patterns.AbstractFactory;

public class PCButton : IButton { public void Render() => Console.WriteLine("Render PC Button"); }
