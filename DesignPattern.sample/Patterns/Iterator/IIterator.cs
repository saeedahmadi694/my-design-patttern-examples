using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Iterator;

public interface IIterator
{
    bool HasNext();
    Item? Next();
}
