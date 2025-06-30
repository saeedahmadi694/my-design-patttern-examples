using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State.ConcrretState;
public class CharacterMoveLeft : ICharacterMove
{
    private readonly CharacterController _controller;

    public CharacterMoveLeft(CharacterController controller)
    {
        _controller = controller;
    }

    public void Attack()
    {
        Console.WriteLine("Attack while moving left.");
        _controller.ChangeState(new CharacterAttack(_controller));
    }

    public void Defend()
    {
        Console.WriteLine("Start defending while moving left.");
        _controller.ChangeState(new CharacterDefend(_controller));
    }

    public void Idle()
    {
        Console.WriteLine("Stop moving, go idle.");
        _controller.ChangeState(new CharacterIdle(_controller));
    }

    public void Jump()
    {
        Console.WriteLine("Jump while moving left.");
        _controller.ChangeState(new CharacterJump(_controller));
    }

    public void Left()
    {
        Console.WriteLine("Already moving left.");
    }

    public void Right()
    {
        Console.WriteLine("Change direction: move right.");
        _controller.ChangeState(new CharacterMoveRight(_controller));
    }

}
