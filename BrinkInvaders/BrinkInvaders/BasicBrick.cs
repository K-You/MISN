using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using BrickInvaders.View;

namespace BrickInvaders
{

    namespace Model
    {

        public class BasicBrick : DynamicElement
        {
            private int health;
            private static Vector2D DEFAULT_SPEED = new Vector2D(0, -1); 

            public BasicBrick(Vector2D position)
                : this(position, DEFAULT_SPEED)
            { }

            public BasicBrick(Vector2D position, Vector2D speed)
                : this(position, speed, new Vector2D(1,1), 1, Color.Blue)
            { }

            public BasicBrick(Vector2D position, Vector2D speed, Vector2D dimensions, int health, Color color)
                : base(position, speed, dimensions)
            {
                this.health = health;
                this.Color = color;
                this.AddObserver(new BrickView(BrickInvaders.frame));
            }

            public int Health
            {
                get { return health; }
                set { health = value; this.NotifyObservers(); }
            }

            public override void NotifyObservers()
            {
                foreach (Observer obs in this._observers)
                {
                    obs.Refresh(this);
                }
            }
        }
    }
}
