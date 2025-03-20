namespace DesignPattern.sample.Patterns.ChainOfResponsibility.Damages;

public class ShieldHandler : DamageHandler
{
    private int shield = 15;

    public override void HandleRequest(ref int damage, string damageType)
    {
        if (shield > 0)
        {
            int absorbed = Math.Min(damage, shield);
            shield -= absorbed;
            damage -= absorbed;
            Console.WriteLine($"Shield absorbs {absorbed} damage. Remaining damage: {damage}");
        }

        if (damage > 0)
        {
            _nextHandler?.HandleRequest(ref damage, damageType);
        }
    }
}