using DesignPattern.sample.Patterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test.State;

public class CharacterControllerTests : IDisposable
{
    private readonly CharacterController _controller;
    private readonly StringWriter _consoleOutput;
    private readonly TextWriter _originalOutput;

    public CharacterControllerTests()
    {
        _originalOutput = Console.Out;
        _consoleOutput = new StringWriter();
        Console.SetOut(_consoleOutput);
        _controller = new CharacterController();
    }

    public void Dispose()
    {
        Console.SetOut(_originalOutput);
        _consoleOutput.Dispose();
    }

    [Fact]
    public void TurnLeft_FromIdle_PrintsWalkLeftAndTransitionsToMoveLeft()
    {
        _controller.TurnLeft();
        _controller.TurnLeft();

        var lines = _consoleOutput.ToString()
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal("Walk left.", lines[0]);
        Assert.Equal("Already moving left.", lines[1]);
    }

    [Fact]
    public void TurnRight_FromIdle_PrintsWalkRightAndTransitionsToMoveRight()
    {
        _controller.TurnRight();
        _controller.TurnRight();

        var lines = _consoleOutput.ToString()
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal("Walk right.", lines[0]);
        Assert.Equal("Already moving right.", lines[1]);
    }

    [Fact]
    public void Jump_FromIdle_PrintsStartJumpingAndTransitionsToJump()
    {
        _controller.Jump();
        _controller.Jump();

        var lines = _consoleOutput.ToString()
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal("Start jumping.", lines[0]);
        Assert.Equal("Already jumping.", lines[1]);
    }

    [Fact]
    public void Defend_FromIdle_PrintsStartDefendingAndTransitionsToDefend()
    {
        _controller.Defend();
        _controller.Defend();

        var lines = _consoleOutput.ToString()
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal("Start defending.", lines[0]);
        Assert.Equal("Already defending.", lines[1]);
    }

    [Fact]
    public void Attack_FromIdle_PrintsStartAttackingAndTransitionsToAttack()
    {
        _controller.Attack();
        _controller.Attack();

        var lines = _consoleOutput.ToString()
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal("Start attacking.", lines[0]);
        Assert.Equal("Already attacking.", lines[1]);
    }
}
