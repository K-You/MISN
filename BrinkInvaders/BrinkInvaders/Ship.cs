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

            public Ship(string label)
                : this(label, new Vector2D(), new Vector2D())
            {
            }

            public Ship(string label, Vector2D position)
                : this(label, position, new Vector2D())
            {
                this.label = label;
            }

            public Ship(string label, Vector2D position, Vector2D speed)
                : base(position, speed)
            {
                this.label = label;
                this.AddObserver(new ShipView());
            }

            public int Health
            {
                get { return health; }
                set { health = value; }
            }

            public string Label
            {
                get { return label; }
                set { label = value; }
            }

            public override void NotifyObservers()
            {
 	            throw new NotImplementedException();
            }

        }
    }
}