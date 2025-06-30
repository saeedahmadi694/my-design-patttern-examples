using DesignPattern.sample.Patterns.Strategy;
using DesignPattern.sample.Patterns.Strategy.ConcrretAttackStrategy;
using DesignPattern.sample.Patterns.Strategy.ConcrretDefenceStrategy;

namespace DesignPattern.Test.Strategy;

public class PlayerTests : IDisposable
{
    private readonly StringWriter _consoleOutput;
    private readonly TextWriter _originalOutput;

    public PlayerTests()
    {
        _consoleOutput = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_consoleOutput);
    }

    public void Dispose()
    {
        Console.SetOut(_originalOutput);
        _consoleOutput.Dispose();
    }

    [Fact]
    public void Player_Performs_SwordAttack()
    {
        var player = new Player(new SwordAttack(), new ShieldDefence());
        player.Attack();
        Assert.Equal("Attacking with a sword!", _consoleOutput.ToString().Trim());
    }

    [Fact]
    public void Player_Performs_BowAttack()
    {
        var player = new Player(new BowAttack(), new ShieldDefence());
        player.Attack();
        Assert.Equal("Attacking with a bow!", _consoleOutput.ToString().Trim());
    }

    [Fact]
    public void Player_Performs_MagicAttack()
    {
        var player = new Player(new MagicAttack(), new ShieldDefence());
        player.Attack();
        Assert.Equal("Casting a magic spell!", _consoleOutput.ToString().Trim());
    }

    [Fact]
    public void Player_Performs_ShieldDefence()
    {
        var player = new Player(new SwordAttack(), new ShieldDefence());
        player.Defend();
        Assert.Equal("Blocking with a shield!", _consoleOutput.ToString().Trim());
    }

    [Fact]
    public void Player_Performs_MartialArtDefence()
    {
        var player = new Player(new SwordAttack(), new MartialArtDefence());
        player.Defend();
        Assert.Equal("Dodging with martial arts!", _consoleOutput.ToString().Trim());
    }

    [Fact]
    public void Player_Can_Change_Attack_Strategy_At_Runtime()
    {
        var player = new Player(new SwordAttack(), new ShieldDefence());
        player.SetAttackStrategy(new MagicAttack());
        player.Attack();
        Assert.Equal("Casting a magic spell!", _consoleOutput.ToString().Trim());
    }

    [Fact]
    public void Player_Can_Change_Defence_Strategy_At_Runtime()
    {
        var player = new Player(new SwordAttack(), new ShieldDefence());
        player.SetDefenceStrategy(new MartialArtDefence());
        player.Defend();
        Assert.Equal("Dodging with martial arts!", _consoleOutput.ToString().Trim());
    }
}
