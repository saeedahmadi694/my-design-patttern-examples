using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Adapter;

public class PCGameController
{
    public void PressButton(string buttonName)
    {
        Console.WriteLine($"PC Game Controller: {buttonName} button pressed.");
    }
    public void MoveJoystick(int x, int y)
    {
        Console.WriteLine($"PC Game Controller: Joystick moved to position ({x}, {y}).");
    }
    public void Connect()
    {
        Console.WriteLine("PC Game Controller connected.");
    }
    public void Disconnect()
    {
        Console.WriteLine("PC Game Controller disconnected.");
    }
}
