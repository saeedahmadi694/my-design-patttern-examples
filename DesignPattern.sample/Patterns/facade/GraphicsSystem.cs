using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.facade;
public class GraphicsSystem
{
    public void InitializeGraphics() { Console.WriteLine("Initializing graphics..."); }
    public void SetResolution(int width, int height) { Console.WriteLine($"Setting resolution to {width}x{height}"); }
    public void LoadTextures() { Console.WriteLine("Loading textures..."); }
}
