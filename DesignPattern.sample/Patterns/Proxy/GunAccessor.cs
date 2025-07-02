using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Proxy;


public class GunAccessProxy : IGameObject
{
    private Gun _realGun;
    private Player _player;

    public GunAccessProxy(Player player)
    {
        _player = player;
        _realGun = new Gun();
    }

    public void Use()
    {
        if (HasAccess())
        {
            _realGun.Use();
        }
        else
        {
            Console.WriteLine("You do not have access to use the gun.");
        }
    }

    private bool HasAccess()
    {
        if (_player.Level < 5)
        {
            Console.WriteLine("You need to reach level 5 to use the gun.");
            return false;
        }

        if (_player.HasEnoughResources() == false)
        {
            Console.WriteLine("You do not have enough resources to use the gun.");
            return false;
        }

        Console.WriteLine("Access granted: You can use the gun.");
        return true;
    }
}