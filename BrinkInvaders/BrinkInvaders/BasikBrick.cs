using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    class BasicBrick:Element
    {
        private int health;
        private BrickView view;


         public BasicBrick(int health, BrickView view, int width, Color color, Point position):base(width, color, position)
        {
            this.health = health;
            this.view = view;
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
