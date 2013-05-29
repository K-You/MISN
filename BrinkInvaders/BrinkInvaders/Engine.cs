using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        class Engine
        {
            private Game _game;

            public Game Game
            {
                get { return _game; }
                set { _game = value; }
            }

            public void start() { }

            public void removeBrik() { }


        }
    }
}
