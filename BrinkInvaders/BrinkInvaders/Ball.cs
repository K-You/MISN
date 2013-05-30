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

        public class Ball : DynamicElement
        {
            private static double DEFAULT_RADIUS = 1;
            private static int DEFAULT_DAMAGE = 1;

            private int _damage;

            public Ball()
                : this(new Vector2D(), new Vector2D(), new Vector2D(DEFAULT_RADIUS, DEFAULT_RADIUS), DEFAULT_DAMAGE)
            {
            }

            public Ball(Vector2D position, Vector2D speed, Vector2D dimensions, int damage)
                : base(position, speed, dimensions)
            {
                this.Damage = damage;
                this.AddObserver(new BallView());
            }

            public int Damage
            {
                get { return _damage; }
                set { _damage = value; }
            }

            public override void NotifyObservers()
            {
                throw new NotImplementedException();
            }
        }
    }
}
