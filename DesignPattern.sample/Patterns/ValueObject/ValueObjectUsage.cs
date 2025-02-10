using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.ValueObject;

public class ValueObjectUsage
{
    public void Run()
    {
        var money1 = new Money(100, "USD");
        var money2 = new Money(200, "EUR");

        if (money1 == money2)
        {
            Console.WriteLine("The two money objects are equal.");
        }
        else
        {
            Console.WriteLine("The two money objects are not equal.");
        }
    }
}
