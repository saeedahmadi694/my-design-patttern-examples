using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Composite;

public class Manager : Employee
{
    public List<Employee> Employees { get; set; }
    public Manager(string title, int type) : base(title, type)
    {
        Employees = [];
    }
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}
