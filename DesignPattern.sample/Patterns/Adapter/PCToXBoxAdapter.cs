namespace DesignPattern.sample.Patterns.Adapter;

public class PCToXBoxAdapter : IGameController
{
    private readonly XBoxGameController _xbox;

    public PCToXBoxAdapter(XBoxGameController xbox)
    {
        _xbox = xbox;
    }

    public void Connect()
    {
        _xbox.PowerOn();
    }

    public void Disconnect()
    {
        _xbox.PowerOff();
    }

    public void MoveJoystick(int x, int y)
    {
        _xbox.MoveAnalogStick(x, y);
    }

    public void PressButton(string buttonName)
    {
        if (buttonName.Equals("A", StringComparison.OrdinalIgnoreCase))
        {
            _xbox.AButtonPressed();
        }
        else
        {
            Console.WriteLine($"Xbox Adapter: Button '{buttonName}' not supported.");
        }
    }
}

