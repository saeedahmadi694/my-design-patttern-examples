
using DesignPattern.sample.Patterns.ChainOfResponsibility;
using System;

namespace DesignPattern.sample.Patterns.AbstractFactory;

public class PCPanel : IPanel { public void Show() => Console.WriteLine("Show PC Panel"); }
