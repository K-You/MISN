using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using System.Drawing;

namespace BrickInvaders
{
    namespace Model
    {

        public class ShipArguments
        {
            private string _label;
            private Vector2D _position;
            private Vector2D _speed;
            private Vector2D _dimensions;
            private int _mass;
            private int _health;
            private Color _color;

            public ShipArguments(string str, Vector2D pos, Vector2D speed, Vector2D dim, int mass, int health, Color color)
            {
                this.Label = str;
                this.Position = pos;
                this.Speed = speed;
                this.Dimension = dim;
                this.Mass = mass;
                this.Health = health;
                this.Color = color;
            }

            public Color Color
            {
                get { return _color; }
                set { _color = value; }
            }


            public int Health
            {
                get { return _health; }
                set { _health = value; }
            }



            public int Mass
            {
                get { return _mass; }
                set { _mass = value; }
            }


            public Vector2D Dimension
            {
                get { return _dimensions; }
                set { _dimensions = value; }
            }


            public Vector2D Speed
            {
                get { return _speed; }
                set { _speed = value; }
            }


            public Vector2D Position
            {
                get { return _position; }
                set { _position = value; }
            }


            public string Label
            {
                get { return _label; }
                set { _label = value; }
            }
        }
    }
}