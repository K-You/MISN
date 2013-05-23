using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    class Ship:DynamicElement
    {
        private string label;
        private int height;
        private int id;
        private ShipView view;

        public Ship(string label, int height, int id, ShipView view, int speed,int width, Color color, Point position)
            : base(speed, width, color, position)
        {
            this.label = label;
            this.height = height;
            this.id = id;
            this.view = view;
        }

        public ShipView View
        {
            get { return view; }
            set { view = value; }
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
