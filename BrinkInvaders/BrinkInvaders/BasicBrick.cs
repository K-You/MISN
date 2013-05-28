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

        public BasicBrick(int health, BrickView view, int width, Color color, Point position)//Absolutely n'importe quoi !
            : base(width, color, position)
        {
            this.health = health;
            this.View = view;
        }

        public BasicBrick(Point position):base(1,Color.Blue,position)
        {
            //surement des choses à compléter
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
