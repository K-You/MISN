using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        public abstract class GameMode
        {
            public MapGenerator Generator { get; set; }

            private string _label;
            private Vector2D _minspeed;
            private Vector2D _maxspeed;
            private List<Score> _scores;
            private static Vector2D DEFAULT_SPEED = new Vector2D();

            public GameMode(MapGenerator Generator, String label)
                : this(Generator, label, DEFAULT_SPEED,DEFAULT_SPEED)
            {
            }

            public GameMode(MapGenerator Generator, String label, Vector2D minspeed, Vector2D maxspeed)
            {
                this.Generator = Generator;
                this.Label = label;
                this.MinSpeed = minspeed;
                this.MaxSpeed = maxspeed;
            }

            public List<Score> getBestScores
            {
                get { return _scores; }
            }

            public Vector2D MinSpeed
            {
                get { return _minspeed; }
                set { _minspeed = value; }
            }
            public Vector2D MaxSpeed
            {
                get { return _maxspeed; }
                set { _maxspeed = value; }
            }


            public string Label
            {
                get { return _label; }
                set { _label = value; }
            }
        }
    }
}
