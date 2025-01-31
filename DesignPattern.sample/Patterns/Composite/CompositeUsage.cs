using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Composite;

public class CompositeUsage
{
    public void Run()
    {
        var cto = new CTO("CTO", 1);

        var manager = new Manager("Manager", 2);

        var developer1 = new Developer("Developer", 3);
        var developer2 = new Developer("Developer", 3);
        var developer3 = new Developer("Developer", 3);
        manager.AddEmployee(developer1);
        manager.AddEmployee(developer2);
        manager.AddEmployee(developer3);

        var emp1 = new Employee("Employee", 3);
        var emp2 = new Employee("Employee", 3);
        var emp3 = new Employee("Employee", 3);
        var emp4 = new Employee("Employee", 3);
        var emp5 = new Employee("Employee", 3);
        cto.AddEmployee(emp1);
        cto.AddEmployee(emp2);
        cto.AddEmployee(emp3);
        cto.AddEmployee(emp3);
        cto.AddEmployee(emp5);


        cto.AddEmployee(manager);
    }
}
