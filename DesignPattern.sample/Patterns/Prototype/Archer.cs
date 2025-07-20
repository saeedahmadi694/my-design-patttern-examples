using DesignPattern.sample.Patterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Prototype;

public class Warrior : ICharacter
{
    public int Health { get; set; }
    public int Stamina { get; set; }
    public string Weapon { get; set; }

    public Warrior(int health, int stamina, string weapon)
    {
        Health = health;
        Stamina = stamina;
        Weapon = weapon;
    }

    public ICharacter Clone()
    {
        return new Warrior(Health, Stamina, Weapon);
    }

    public void Display()
    {
        Console.WriteLine($"Warrior - Health: {Health}, Stamina: {Stamina}, Weapon: {Weapon}");
    }
}