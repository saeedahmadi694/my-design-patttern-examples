namespace DesignPattern.sample.Patterns.Adapter;

public class XBoxToPCAdapter : IGameController
{
    private readonly PCGameController _pCGameController;

    public XBoxToPCAdapter(PCGameController pCGameController)
    {
        _pCGameController = pCGameController;
    }

    public void Connect()
    {
        _pCGameController.Connect();
    }

    public void Disconnect()
    {
        _pCGameController.Disconnect();
    }

    public void MoveJoystick(int x, int y)
    {
        _pCGameController.MoveJoystick(x, y);
    }

    public void PressButton(string buttonName)
    {
        _pCGameController.PressButton(buttonName);
    }
}
