namespace DesignPattern.sample.Patterns.Composite;

public class Developer : Employee
{
    public string Position { get; set; }
    public string Stack { get; set; }
    public Developer(string title, int type) : base(title, type)
    {
    }
}
