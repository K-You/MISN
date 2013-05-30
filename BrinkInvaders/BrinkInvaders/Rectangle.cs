using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickInvaders
{
    namespace Model
    {

        public class Rectangle
        {
            private double _width;
            private double _height;
            private Vector2D _point;

            public Rectangle()
                : this(0, 0, 0, 0)
            {
            }

            public Rectangle(double width, double height)
                : this(width, height, 0, 0)
            {
            }

            public Rectangle(double width, double height, Vector2D origin)
            {
                this.Width = width;
                this.Height = height;
                this.Origin = origin;
            }

            public Rectangle(double width, double height, double x, double y)
                : this(width, height, new Vector2D(x, y))
            {
            }

            public Vector2D Origin
            {
                get { return _point; }
                set { _point = value; }
            }


            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }


            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }
        }
    }
}