using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State.ConcrretState;

public class CharacterMoveRight : ICharacterMove
{
    private readonly CharacterController _controller;

    public CharacterMoveRight(CharacterController controller)
    {
        _controller = controller;
    }

    public void Attack()
    {
        Console.WriteLine("Attack while moving right.");
        _controller.ChangeState(new CharacterAttack(_controller));
    }

    public void Defend()
    {
        Console.WriteLine("Start defending while moving right.");
        _controller.ChangeState(new CharacterDefend(_controller));
    }

    public void Idle()
    {
        Console.WriteLine("Stop moving, go idle.");
        _controller.ChangeState(new CharacterIdle(_controller));
    }

    public void Jump()
    {
        Console.WriteLine("Jump while moving right.");
        _controller.ChangeState(new CharacterJump(_controller));
    }

    public void Left()
    {
        Console.WriteLine("Change direction: move left.");
        _controller.ChangeState(new CharacterMoveLeft(_controller));
    }

    public void Right()
    {
        Console.WriteLine("Already moving right.");
    }

}
