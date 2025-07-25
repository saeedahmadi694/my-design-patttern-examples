using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Factory;


public class Sword : IWeapon
{
    public void Attack() => Console.WriteLine("Swinging a sword!");
}
