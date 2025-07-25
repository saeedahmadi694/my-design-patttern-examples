using DesignPattern.sample.Patterns.Decorator.Abilities;

namespace DesignPattern.sample.Patterns.Factory;

public class FactoryUsage
{
    public void Run()
    {
        IWeapon playerWeapon = WeaponFactory.CreateWeapon("Mage");
        playerWeapon.Attack();
    }
}
