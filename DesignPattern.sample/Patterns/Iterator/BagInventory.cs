using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Iterator;

public class BagInventory : IInventory<Item>
{
    private readonly IIterator _iterator;
    private readonly List<Item> _items = [];

    public BagInventory(IIterator iterator)
    {
        _iterator = iterator;
    }
    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public List<Item> GetItems()
    {
        return _items;
    }
    public IIterator GetIterator()
    {
        return _iterator;
    }
}
