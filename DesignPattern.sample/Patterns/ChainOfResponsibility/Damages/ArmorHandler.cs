namespace DesignPattern.sample.Patterns.ChainOfResponsibility.Damages;

public class ArmorHandler : DamageHandler
{
    private int armor = 10;
    public override void HandleRequest(ref int damage, string type)
    {
        int reducedDamage = Math.Max(damage - armor, 0);
        Console.WriteLine($"Armor reduces damage from {damage} to {reducedDamage}");
        damage = reducedDamage;

        _nextHandler?.HandleRequest(ref damage, type);
    }
}
