using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Composite;

public class Employee
{
    public string Title { get; set; }
    public int Type { get; set; }
    public Employee(string title, int type)
    {
        Title = title;
        Type = type;
    }
}
