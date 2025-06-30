using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State.ConcrretState;
public class CharacterIdle : ICharacterMove
{
    private readonly CharacterController _controller;

    public CharacterIdle(CharacterController controller)
    {
        _controller = controller;
    }

    public void Attack()
    {
        Console.WriteLine("Start attacking.");
        _controller.ChangeState(new CharacterAttack(_controller));
    }

    public void Defend()
    {
        Console.WriteLine("Start defending.");
        _controller.ChangeState(new CharacterDefend(_controller));
    }

    public void Idle()
    {
        Console.WriteLine("Already idle.");
    }

    public void Jump()
    {
        Console.WriteLine("Start jumping.");
        _controller.ChangeState(new CharacterJump(_controller));
    }

    public void Left()
    {
        Console.WriteLine("Walk left.");
        _controller.ChangeState(new CharacterMoveLeft(_controller));
    }

    public void Right()
    {
        Console.WriteLine("Walk right.");
        _controller.ChangeState(new CharacterMoveRight(_controller));
    }

}
