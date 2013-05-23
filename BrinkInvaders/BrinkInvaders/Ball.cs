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

        public Ball(int id, BallView view, int speed,int width, Color color, Point position)
            : base(speed, width, color, position)
        {
            this.id = id;
            this.view = view;
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
