
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Singleton;
public class GameSettingsManager
{
    private static GameSettingsManager _instance;

    private GameSettingsManager()
    {
        Difficulty = "Normal";
        Language = "en";
        Volume = 0.8f;
    }

    public static GameSettingsManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameSettingsManager();

            return _instance;
        }
    }

    public string Difficulty { get; set; }
    public string Language { get; set; }
    public float Volume { get; set; }

}
