using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickInvaders
{

    namespace Model
    {

        public class BasicBrick : Element
        {
            private int health;

            public BasicBrick(Point position)
                : this(position, 2, 1, Color.Blue)
            {
            }

            public BasicBrick(Point position, int width, int health, Color color)
                : base(position)
            {
                this.Width = width;
                this.health = health;
                this.Color = color;
                this.Position = position;
            }

            public int Health
            {
                get { return health; }
                set { health = value; }
            }

        }

    }
}
