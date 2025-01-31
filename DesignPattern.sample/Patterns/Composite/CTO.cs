namespace DesignPattern.sample.Patterns.Composite;

public class CTO : Employee
{
    public List<Employee> Employees { get; set; }
    public CTO(string title, int type) : base(title, type)
    {
        Employees = [];
    }
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}
