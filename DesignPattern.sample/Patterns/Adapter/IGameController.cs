using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Adapter;

public interface IGameController
{
    void PressButton(string buttonName);
    void MoveJoystick(int x, int y);
    void Connect();
    void Disconnect();
}
