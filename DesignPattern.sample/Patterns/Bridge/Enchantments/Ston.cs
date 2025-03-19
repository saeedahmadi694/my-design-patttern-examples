namespace DesignPattern.sample.Patterns.Bridge.Enchantments;

public class Ston : IEnchantment
{
    public void Apply()
    {
        Console.WriteLine("The item is stoned");
    }
}