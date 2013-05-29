using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using BrickInvaders.Controller;

namespace BrickInvaders
{

    class BrickInvaders
    {

        static void Main(string[] args)
        {
            GameMode g = new BasicMode();
            KeyBinding k = new KeyBinding();
            Configuration c = new Configuration(g, k);
            Model.Player player = new Model.Player("Red the moine", 1);
            Console.WriteLine(player.Pseudo);


            BasicMapGenerator gen = new BasicMapGenerator();
            gen.test();
            Console.Read();
        }

    }
}
