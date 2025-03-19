﻿using DesignPattern.sample.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Bridge.Enchantments;

public class Ice : IEnchantment
{
    public void Apply()
    {
        Console.WriteLine("The item is frozen");
    }
}