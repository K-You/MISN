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
            private GameMode _gameMode;
            private KeyBinding _keys;
            private ShipArguments _ship;

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
                this._keys = keys;
                this._ship = ship;
                this._gameMode = gameMode;
            }

            public GameMode GameMode
            {
                get { return _gameMode; }
                set { _gameMode = value; }
            }

            public KeyBinding Keys
            {
                get { return _keys; }
                set { _keys = value; }
            }

            public void InitialiseModel(ModelInterface m)
            {
                MapGenerator g = this.GameMode.Generator;

                m.SetStopped(false);

                m.SetMapDimensions(new Vector2D(this.Width, this.Height));

                this._ship.Position = new Vector2D((this.Width - this._ship.Dimension.X) / 2, 0);
                m.AddShip(this._ship);

                m.SetBricks(g.generateMap(m.GetLevel(), this.Width, this.LevelHeight, this.GameMode.MinSpeed));

                m.AddBall();
            }
        }
    }
}
