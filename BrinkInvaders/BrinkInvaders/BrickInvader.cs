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

        private Game _game;

        public Game Game
        {
            get { return _game; }
            set { _game = value; }
        }

        static void Main(string[] args)
        {
            Model.Player player = new Model.Player("Red the moine", 1);
            Console.WriteLine(player.Pseudo);


            BasicMapGenerator gen = new BasicMapGenerator();
            gen.test();
            Console.Read();
        }

    }
}
