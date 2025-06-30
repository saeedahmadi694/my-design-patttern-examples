using DesignPattern.sample.Patterns.State.ConcrretState;

namespace DesignPattern.sample.Patterns.State;

public class CharacterController
{
    private ICharacterMove _character;
    public CharacterController()
    {
        _character = new CharacterIdle(this);
    }
    public void TurnLeft()
    {
        _character.Left();
    }
    public void TurnRight()
    {
        _character.Right();
    }
    public void Jump()
    {
        _character.Jump();
    }
    public void Defend()
    {
        _character.Defend();
    }
    public void Attack()
    {
        _character.Attack();
    }
    public void ChangeState(ICharacterMove newState)
    {
        _character = newState;
    }
}
