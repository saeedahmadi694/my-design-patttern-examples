namespace DesignPattern.sample.Patterns.Iterator;

internal class BagInventoryIterator : IIterator
{
    private readonly IInventory<Item> _inventory;
    private int _currentIndex = 0;

    public BagInventoryIterator(IInventory<Item> inventory)
    {
        _inventory = inventory;
    }

    public bool HasNext()
    {
        return _currentIndex < _inventory.GetItems().Count;
    }

    public Item? Next()
    {
        if (HasNext())
        {
            return _inventory.GetItems()[_currentIndex++];
        }
        return null;
    }
}
