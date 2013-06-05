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

        public class Ship : DynamicElement
        {
            private string _label;
            private int _health;

            public static readonly Vector2D DEFAULT_POSITION = new Vector2D(-1,-1);
            public static readonly Vector2D DEFAULT_SPEED = new Vector2D(0.25, 0);
            public static readonly Vector2D DEFAULT_DIMENSIONS = new Vector2D(1, 1);
            public static readonly int DEFAULT_MASS = int.MaxValue;
            public static readonly Color DEFAULT_COLOR = Color.Black;
            public static readonly int DEFAULT_HEALTH = 1;

            public Ship(string label)
                : this(label, DEFAULT_POSITION)
            {
            }

            public Ship(string label, Vector2D position)
                : this(label, position, DEFAULT_SPEED, DEFAULT_DIMENSIONS, DEFAULT_MASS, DEFAULT_HEALTH)
            {
            }

            public Ship(string label, Vector2D position, Vector2D speed, Vector2D dimensions, int mass, int health)
                : this(label, position, speed, dimensions, mass, health, DEFAULT_COLOR)
            {
            }

            public Ship(string label, Vector2D position, Vector2D speed, Vector2D dimensions,  int mass, int health, Color color)
                : base(position, speed, dimensions, mass, color)
            {
                this._label = label;
                this._health = health;
                this.AddObserver(new ShipView(BrickInvaders._frame));
                this.NotifyObservers();
            }

            public int Health
            {
                get { return _health; }
                set { _health = value; this.NotifyObservers(); }
            }

            public string Label
            {
                get { return _label; }
                set { _label = value; this.NotifyObservers(); }
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