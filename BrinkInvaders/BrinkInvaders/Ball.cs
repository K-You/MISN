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
        // Cette classe est celle de la balle, elle inflige des dégâts aux briques, d'où son membre _damage
        {
            private static double DEFAULT_RADIUS = 1;
            private static int DEFAULT_DAMAGE = 1;

            private int _damage;

            public Ball()
                : this(new Vector2D(), new Vector2D(), new Vector2D(DEFAULT_RADIUS, DEFAULT_RADIUS), DEFAULT_DAMAGE, (int)DEFAULT_RADIUS)
            {
            }

            public Ball(Vector2D position, Vector2D speed, Vector2D dimensions, int damage, int mass)
                : base(position, speed, dimensions, mass)
            {
                this.Damage = damage;
                this.AddObserver(new BallView(BrickInvaders._frame));
            }

            public int Damage
            {
                get { return _damage; }
                set { _damage = value; this.NotifyObservers(); }
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
