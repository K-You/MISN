using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickInvaders
{

    namespace Model {

        public abstract class DynamicElement : Element
        {
            private int speed;

            public DynamicElement()
            {
                this.speed = 5; // dur
            }
            public DynamicElement(Vector2D position, int speed)
                : base(position)
            {
                this.speed = speed;
            }

            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }

            public void Move(int x, int y)
            {
                this.Position += new Vector2D(x, y);
            }
        }
    }
}


