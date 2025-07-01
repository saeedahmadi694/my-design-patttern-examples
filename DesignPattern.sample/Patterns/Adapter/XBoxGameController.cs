using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Adapter;

public class XBoxGameController
{
    public void AButtonPressed()
    {
        Console.WriteLine("Xbox Controller: A button was pressed.");
    }

    public void MoveAnalogStick(float horizontal, float vertical)
    {
        Console.WriteLine($"Xbox Controller: Stick moved to ({horizontal}, {vertical})");
    }

    public void PowerOn()
    {
        Console.WriteLine("Xbox Controller powered on.");
    }

    public void PowerOff()
    {
        Console.WriteLine("Xbox Controller powered off.");
    }
}

