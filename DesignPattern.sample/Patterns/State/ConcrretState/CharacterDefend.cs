using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State.ConcrretState;

public class CharacterDefend : ICharacterMove
{
    private readonly CharacterController _controller;

    public CharacterDefend(CharacterController controller)
    {
        _controller = controller;
    }

    public void Attack()
    {
        Console.WriteLine("Switching from defend to attack.");
        _controller.ChangeState(new CharacterAttack(_controller));
    }

    public void Defend()
    {
        Console.WriteLine("Already defending.");
    }

    public void Idle()
    {
        Console.WriteLine("Switching from defend to idle.");
        _controller.ChangeState(new CharacterIdle(_controller));
    }

    public void Jump()
    {
        Console.WriteLine("Can't jump while defending.");
    }

    public void Left()
    {
        Console.WriteLine("Can't move left while defending.");
    }

    public void Right()
    {
        Console.WriteLine("Can't move right while defending.");
    }

    public void Run()
    {
        Console.WriteLine("Can't run while defending.");
    }
}
