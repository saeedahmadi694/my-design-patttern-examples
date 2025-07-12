using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.facade;

public class GameFacade
{
    private readonly GraphicsSystem _graphicsSystem;
    private readonly AudioSystem _audioSystem;
    private readonly PhysicsSystem _physicsSystem;
    private readonly UserAuthSystem _userAuthSystem;

    public GameFacade()
    {
        _graphicsSystem = new GraphicsSystem();
        _audioSystem = new AudioSystem();
        _physicsSystem = new PhysicsSystem();
        _userAuthSystem = new UserAuthSystem();
    }

    public void StartGame(string username, string password)
    {
        _userAuthSystem.LoginUser(username, password);
        _userAuthSystem.InitializeMultiplayerSession();
        _graphicsSystem.InitializeGraphics();
        _graphicsSystem.SetResolution(1920, 1080);
        _graphicsSystem.LoadTextures();
        _audioSystem.InitializeAudio();
        _audioSystem.SetVolume(0.8f);
        _audioSystem.PlayBackgroundMusic();
        _physicsSystem.InitializePhysics();
        _physicsSystem.SetGravity(9.8f);
        Console.WriteLine("Game has started!");
    }
}
