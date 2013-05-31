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

            private static Vector2D DEFAULT_POSITION = new Vector2D();
            private static Vector2D DEFAULT_DIMENSIONS = new Vector2D(1,1);
            private static Color DEFAULT_COLOR = Color.Blue;
            private static int DEFAULT_MASS = int.MaxValue;

            private Rectangle _innerRectangle;
            private Color _color;
            private int _mass;

            public Element()
                : this(DEFAULT_POSITION)
            {
            }

            public Element(Vector2D position)
                : this(position, DEFAULT_DIMENSIONS)
            {
            }

            public Element(Vector2D position, Vector2D dimensions)
                : this(position, dimensions, DEFAULT_MASS)
            {
            }

            public Element(Vector2D position, Vector2D dimensions, int mass)
                : this(position, dimensions, mass, DEFAULT_COLOR)
            {
            }

            public Element(Vector2D position, Vector2D dimensions, int mass, Color color)
            {
                this._innerRectangle = new Rectangle(dimensions.X, dimensions.Y, position);
                this.Color = color;
                this._mass = mass;
            }

            public int Mass
            {
                get { return _mass; }
                set { _mass = value; }
            }

            public Vector2D Position
            {
                get { return _innerRectangle.Origin; }
                set { _innerRectangle.Origin = value; this.NotifyObservers(); }
            }

            public Color Color
            {
                get { return _color; }
                set { _color = value; this.NotifyObservers(); }
            }

            public double Width
            {
                get { return _innerRectangle.Width; }
                set { _innerRectangle.Width = value; this.NotifyObservers(); }
            }

            public double Height
            {
                get { return _innerRectangle.Height; }
                set { _innerRectangle.Height = value; this.NotifyObservers(); }
            }

            public Rectangle BoundingBox
            {
                get { return _innerRectangle; }
            }
        }
    }
}
