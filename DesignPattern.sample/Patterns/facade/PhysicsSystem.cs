using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.facade;


public class PhysicsSystem
{
    public void InitializePhysics() { Console.WriteLine("Initializing physics..."); }
    public void SetGravity(float gravity) { Console.WriteLine($"Setting gravity to {gravity}"); }
}
