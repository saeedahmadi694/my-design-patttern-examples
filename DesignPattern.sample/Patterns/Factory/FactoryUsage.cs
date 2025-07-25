using DesignPattern.sample.Patterns.Decorator.Abilities;
using DesignPattern.sample.Patterns.Factory;

namespace DesignPattern.sample.Patterns.FlyWeight;

public class FactoryUsage
{
    public void Run()
    {
        IWeapon playerWeapon = WeaponFactory.CreateWeapon("Mage");
        playerWeapon.Attack();
    }
}
