using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickInvaders
{

    namespace Model
    {

        public class Vector2D : ICloneable
        {
            private double _x;
            private double _y;

            public Vector2D()
                : this(0, 0)
            {

            }

            public Vector2D(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }

            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public double X
            {
                get { return _x; }
                set { _x = value; }
            }

            public void invert()
            {
                this.invertX();
                this.invertY();
            }

            public void invertX()
            {
                this.X = -this.X;
            }

            public void invertY()
            {
                this.Y = -this.Y;
            }

            public void multiply(double coefficient)
            {
                this.X = this.X * coefficient;
                this.Y = this.Y * coefficient;
            }

            public static Vector2D operator +(Vector2D v1, Vector2D v2)
            {
                return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
            }

            public static Vector2D operator -(Vector2D v1, Vector2D v2)
            {
                return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
            }

            public static Vector2D operator *(Vector2D v1, double coeff)
            {
                return new Vector2D(v1.X * coeff, v1.Y * coeff);
            }

            public object Clone()
            {
                return new Vector2D(this.X, this.Y);
            }
        }
    }
}
