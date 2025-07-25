namespace DesignPattern.sample.Patterns.Factory;

public class Bow : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Shooting an arrow!");
    }
}
