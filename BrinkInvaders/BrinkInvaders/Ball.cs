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
            private BallView view;

            public Ball()
            {
                this.View = new BallView();
            }

            public Ball(Vector2D position, Vector2D speed)
                : base(position, speed)
            {
                this.View = new BallView();
            }

            public BallView View
            {
                get { return view; }
                set { view = value; }
            }

            public override void NotifyObservers()
            {
                throw new NotImplementedException();
            }

        }
    }
}
