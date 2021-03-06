﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickInvaders
{

    namespace Model
    {

        public abstract class DynamicElement : Element
        {
            private Vector2D _speed;

            public DynamicElement(Vector2D position, Vector2D speed, Vector2D dimensions)
                : base(position, dimensions)
            {
                this._speed = speed;
            }

            public DynamicElement(Vector2D position, Vector2D speed, Vector2D dimensions, int mass)
                : base(position, dimensions, mass)
            {
                this._speed = speed;
            }

            public DynamicElement(Vector2D position, Vector2D speed, Vector2D dimensions, int mass, Color color)
                : base(position, dimensions, mass, color)
            {
                this._speed = speed;
            }

            public Vector2D Speed
            {
                get { return _speed; }
                set { _speed = value; this.NotifyObservers(); }
            }
        }
    }
}


