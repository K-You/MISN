using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{
    namespace Model
    {

        public abstract class Element : Observable
        {

            private int width;
            private Color color;
            private Vector2D position;

            public Element()
                : this(new Vector2D(10, 10))
            {

            }
            public Element(Vector2D position)
                : this(position, 2)
            {
            }
            public Element(Vector2D position, int width)
                : this(position, width, Color.Blue)
            {
            }
            public Element(Vector2D position, int width, Color color)
            {
                this.position = position;
                this.color = color;
                this.width = width;
            }

            public Vector2D Position
            {
                get { return position; }
                set { position = value; }
            }


            public Color Color
            {
                get { return color; }
                set { color = value; }
            }

            public int Width
            {
                get { return width; }
                set { width = value; }
            }

            public void NextStep()
            {
                this.position.Y++;
            }

            public override void NotifyObservers()
            {
            }

        }
    }
}
