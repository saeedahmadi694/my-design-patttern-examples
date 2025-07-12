using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.facade;

public class AudioSystem
{
    public void InitializeAudio() { Console.WriteLine("Initializing audio system..."); }
    public void SetVolume(float volume) { Console.WriteLine($"Setting volume to {volume}"); }
    public void PlayBackgroundMusic() { Console.WriteLine("Playing background music..."); }
}
