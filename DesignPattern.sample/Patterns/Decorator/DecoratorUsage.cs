﻿using DesignPattern.sample.Patterns.Decorator.Abilities;

namespace DesignPattern.sample.Patterns.Decorator;

public class DecoratorUsage
{
    public void Run()
    {
        var myCharacter = new Character("saeed", 45);

        myCharacter = new ArmorDecorator(myCharacter);
        myCharacter = new FireEnchantmentDecorator(myCharacter);
        myCharacter = new SpeedBoostDecorator(myCharacter);

        myCharacter.Display();
    }
}
