using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        public class Configuration : ConfigurationInterface
        {
            private GameMode gameMode;
            private KeyBinding keys;
            private ShipArguments ship;

            private Vector2D _dimensions = new Vector2D(7, 11);
            private int _levelheight = 20;

            public int LevelHeight
            {
                get { return _levelheight; }
                set { _levelheight = value; }
            }

            public int Width
            {
                get { return (int)_dimensions.X; }
                set { _dimensions.X = value; }
            }

            public int Height
            {
                get { return (int)_dimensions.Y; }
                set { _dimensions.Y = value; }
            }

            public Configuration(GameMode gameMode, ShipArguments ship, KeyBinding keys)
            {
                this.keys = keys;
                this.ship = ship;
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

                m.SetMapDimensions(new Vector2D(this.Width, this.Height));

                this.ship.Position = new Vector2D((this.Width - this.ship.Dimension.X) / 2, 0);
                m.AddShip(this.ship);

                m.SetBricks(g.generateMap(m.GetLevel(), this.Width, this.LevelHeight, this.GameMode.MinSpeed));

                m.AddBall();
            }
        }
    }
}
