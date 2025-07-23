using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.FlyWeight;
internal class Tree
{
    private TreeFlyweight _flyweight;
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public int Health { get; set; }

    public Tree(TreeFlyweight flyweight)
    {
        _flyweight = flyweight;
    }

    public void Plant(float positionX, float positionY, int height, int age, int health)
    {
        PositionX = positionX;
        PositionY = positionY;
        Height = height;
        Age = age;
        Health = health;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing {_flyweight.Species} tree at ({PositionX}, {PositionY}) with texture {_flyweight.Texture}");
    }
}
