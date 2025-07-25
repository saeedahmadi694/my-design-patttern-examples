
using DesignPattern.sample.Patterns.ChainOfResponsibility;
using System;

namespace DesignPattern.sample.Patterns.AbstractFactory;

public class PCSlider : ISlider { public void Slide() => Console.WriteLine("Slide PC Slider"); }

