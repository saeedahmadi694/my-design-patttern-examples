using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Proxy;

public class Gun : IGameObject
{
    public void Use()
    {
        Console.WriteLine("The gun is being used.");
    }
}