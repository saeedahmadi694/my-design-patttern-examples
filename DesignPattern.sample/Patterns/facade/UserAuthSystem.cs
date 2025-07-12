using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.facade;
public class UserAuthSystem
{
    public void LoginUser(string username, string password) { Console.WriteLine($"Logging in user: {username}"); }
    public void InitializeMultiplayerSession() { Console.WriteLine("Initializing multiplayer session..."); }
}