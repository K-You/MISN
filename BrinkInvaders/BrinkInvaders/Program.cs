﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Red the moine", 1);
            Console.WriteLine(player.Pseudo);
            

            BasicMapGenerator gen = new BasicMapGenerator();
            gen.test();
            Console.Read();
        }
    }
}