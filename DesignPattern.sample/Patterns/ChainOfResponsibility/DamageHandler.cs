namespace DesignPattern.sample.Patterns.ChainOfResponsibility;

public abstract class DamageHandler
{
    protected DamageHandler _nextHandler;

    public DamageHandler SetNext(DamageHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return this;
    }

    public abstract void HandleRequest(ref int damage, string type);
}
