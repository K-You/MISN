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
            private Vector2D _stepspeed;
            private static Vector2D DEFAULT_SPEED = new Vector2D();

            public GameMode(MapGenerator Generator, String label)
                : this(Generator, label, DEFAULT_SPEED,DEFAULT_SPEED)
            {
            }

            public GameMode(MapGenerator Generator, String label, Vector2D minspeed, Vector2D stepspeed)
            {
                this.Generator = Generator;
                this.Label = label;
                this.MinSpeed = minspeed;
                this.StepSpeed = stepspeed;
            }

            public Vector2D MinSpeed
            {
                get { return _minspeed; }
                set { _minspeed = value; }
            }
            public Vector2D StepSpeed
            {
                get { return _stepspeed; }
                set { _stepspeed = value; }
            }

            public string Label
            {
                get { return _label; }
                set { _label = value; }
            }
        }
    }
}
