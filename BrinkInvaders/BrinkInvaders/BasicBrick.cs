using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    public class BasicBrick:Element
    {
        private int health;
        private BrickView view;

        public BasicBrick(Point position):base(position)
        {
            this.Width = 2; // dur
            this.health = 1; // dur
            this.Color = Color.Blue;
            this.Position = position;
        }

        public BrickView View
        {
            get { return view; }
            set { view = value; }
        }

        
        public int Health
        {
            get { return health; }
            set { health = value; }
        }




        
    }
}
