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
            private int id;
            private BallView view;

            public Ball(int id)
            {
                this.id = id;
                this.View = new BallView();
            }

            public Ball(Vector2D position, int speed, int id)
                : base(position, speed)
            {
                this.id = id;
                this.View = new BallView();
            }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public BallView View
            {
                get { return view; }
                set { view = value; }
            }

        }
    }
}
