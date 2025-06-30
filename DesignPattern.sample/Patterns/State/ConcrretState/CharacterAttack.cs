using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.State.ConcrretState;
public class CharacterAttack : ICharacterMove
{
    private readonly CharacterController _controller;

    public CharacterAttack(CharacterController controller)
    {
        _controller = controller;
    }

    public void Attack()
    {
        Console.WriteLine("Already attacking.");
    }

    public void Defend()
    {
        Console.WriteLine("Transition to Defend.");
        _controller.ChangeState(new CharacterDefend(_controller));
    }

    public void Idle()
    {
        Console.WriteLine("Transition to Idle.");
        _controller.ChangeState(new CharacterIdle(_controller));
    }

    public void Jump()
    {
        Console.WriteLine("Can't jump while attacking.");
    }

    public void Left()
    {
        Console.WriteLine("Can't move left while attacking.");
    }

    public void Right()
    {
        Console.WriteLine("Can't move right while attacking.");
    }

}
