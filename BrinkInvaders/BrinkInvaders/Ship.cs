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
            private string label;
            private int health;

            private static Vector2D DEFAULT_POSITION = new Vector2D();
            private static Vector2D DEFAULT_SPEED = new Vector2D();
            private static Vector2D DEFAULT_DIMENSIONS = new Vector2D();

            public Ship(string label)
                : this(label, DEFAULT_POSITION, DEFAULT_SPEED, DEFAULT_DIMENSIONS)
            {
            }

            public Ship(string label, Vector2D position)
                : this(label, position, DEFAULT_SPEED, DEFAULT_DIMENSIONS)
            {
                this.label = label;
            }

            public Ship(string label, Vector2D position, Vector2D speed, Vector2D dimensions)
                : base(position, speed, dimensions)
            {
                this.label = label;
                this.AddObserver(new ShipView());
            }

            public int Health
            {
                get { return health; }
                set { health = value; this.NotifyObservers(); }
            }

            public string Label
            {
                get { return label; }
                set { label = value; this.NotifyObservers(); }
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