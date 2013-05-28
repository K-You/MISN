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

        public Ship(string label, int height, int id, int health, ShipView view, int speed,int width, Color color, Point position)//absolutely n'importe quoi
            : base(speed, width, color, position)
        {
            this.label = label;
            this.height = height;
            this.id = id;
            this.height = health;
            this.view = view;
        }

        public Ship(String label):this(label,1,0,1,null,1,4,Color.Red,new Point())//A revoir !!
        {
        }

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
