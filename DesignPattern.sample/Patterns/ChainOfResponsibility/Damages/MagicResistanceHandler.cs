namespace DesignPattern.sample.Patterns.ChainOfResponsibility.Damages;

public class MagicResistanceHandler : DamageHandler
{
    private double resistance = 0.2; 

    public override void HandleRequest(ref int damage, string damageType)
    {
        if (damageType == "Magic")
        {
            int reducedDamage = (int)(damage * (1 - resistance));
            Console.WriteLine($"Magic resistance reduces damage from {damage} to {reducedDamage}");
            damage = reducedDamage;
        }

        _nextHandler?.HandleRequest(ref damage, damageType);
    }
}