using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    public class Ball : DynamicElement
    {


        private int id;
        private BallView view;


        public Ball(Point position, int speed, int id)
            : base(position, speed)
        {
            this.id = id;
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
