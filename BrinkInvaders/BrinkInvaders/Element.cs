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

            private Rectangle _innerRectangle;
            private Color _color;
            private bool _modified = true;

            public Element()
                : this(new Vector2D())
            {

            }

            public Element(Vector2D position)
                : this(position, new Vector2D(1,1))
            {
            }

            public Element(Vector2D position, Vector2D dimensions)
                : this(position, dimensions, Color.Blue)
            {
            }

            public Element(Vector2D position, Vector2D dimensions, Color color)
            {
                this._innerRectangle.Width = dimensions.X;
                this._innerRectangle.Height = dimensions.Y;
                this._innerRectangle.Origin = position;
                this.Color = color;
            }

            public Vector2D Position
            {
                get { return _innerRectangle.Origin; }
                set { _innerRectangle.Origin = value; }
            }

            public Color Color
            {
                get { return _color; }
                set { _color = value; }
            }

            public double Width
            {
                get { return _innerRectangle.Width; }
                set { _innerRectangle.Width = value; }
            }

            public double Height
            {
                get { return _innerRectangle.Height; }
                set { _innerRectangle.Height = value; }
            }

            public Rectangle BoundingBox
            {
                get { return _innerRectangle; }
            }
        }
    }
}
