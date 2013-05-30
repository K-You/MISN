using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        class Configuration : ConfigurationInterface
        {
            private GameMode gameMode;
            private KeyBinding keys;

            public int Width { get; set; }
            public int LevelHeight { get; set; }

            public Configuration(GameMode gameMode, KeyBinding keys)
            {
                this.keys = keys;
                this.gameMode = gameMode;
            }

            public GameMode GameMode
            {
                get { return gameMode; }
                set { gameMode = value; }
            }

            public KeyBinding Keys
            {
                get { return keys; }
                set { keys = value; }
            }

            public void InitialiseModel(ModelInterface m)
            {
                MapGenerator g = this.GameMode.Generator;
                m.SetBricks(g.generateMap(m.GetLevel(), this.Width, this.LevelHeight));
                m.SetShip(g.generateShip());
            }
        }
    }
}
