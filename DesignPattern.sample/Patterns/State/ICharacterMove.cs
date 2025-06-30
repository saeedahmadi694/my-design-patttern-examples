using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State;

public interface ICharacterMove
{
    void Idle();
    void Left();
    void Right();
    void Jump();
    void Defend();
    void Attack();
}
