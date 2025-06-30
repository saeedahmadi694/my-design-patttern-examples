using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State.ConcrretState;

public class CharacterJump : ICharacterMove
{
    private readonly CharacterController _controller;

    public CharacterJump(CharacterController controller)
    {
        _controller = controller;
    }

    public void Attack()
    {
        Console.WriteLine("Attack while in air.");
        _controller.ChangeState(new CharacterAttack(_controller));
    }

    public void Defend()
    {
        Console.WriteLine("Can't defend while jumping.");
    }

    public void Idle()
    {
        Console.WriteLine("Landing to idle.");
        _controller.ChangeState(new CharacterIdle(_controller));
    }

    public void Jump()
    {
        Console.WriteLine("Already jumping.");
    }

    public void Left()
    {
        Console.WriteLine("Air control: move left.");
    }

    public void Right()
    {
        Console.WriteLine("Air control: move right.");
    }

    public void Run()
    {
        Console.WriteLine("Can't start running mid-air.");
    }
}
