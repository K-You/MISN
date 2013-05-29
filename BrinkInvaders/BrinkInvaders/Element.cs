using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public abstract class Element:Observable
    {

        private int width;
        private Color color;
        private Point position;

        public Element():this(new Point(10,10))
        {
            
        }
        public Element(Point position):this(position, 2)
        {
        }
        public Element(Point position, int width):this(position, width, Color.Blue)
        {
        }
        public Element(Point position, int width, Color color)
        {
            this.position = position;  
            this.color = color;    
            this.width = width;    
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }


        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public void NextStep()
        {
            this.position.Y++;
        }

    }
}
