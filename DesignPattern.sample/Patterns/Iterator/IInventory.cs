using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Iterator;

public interface IInventory<T> where T : class
{
    List<T> GetItems();
    IIterator GetIterator();
}
