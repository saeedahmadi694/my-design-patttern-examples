using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Prototype;

public interface ICharacter
{
    ICharacter Clone();
    void Display();
}
