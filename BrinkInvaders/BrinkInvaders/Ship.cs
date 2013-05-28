using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    public class Ship:DynamicElement
    {
        private string label;
        private int height;
        private int id;
        private int health;
        private ShipView view;


        public ShipView View
        {
            get { return view; }
            set { view = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }   

        public int Id
        {
            get { return id; }
        }        

        public int Height
        {
            get { return height; }
            set { height = value; }
        }        

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
    }
}
