using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    public abstract class DynamicElement : Element
    {
        private int speed;

        public DynamicElement()
        {
            this.speed = 5;
        }
        public DynamicElement(Point position, int speed): base(position)
        {
            this.speed = speed;
        }  

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Move(int x, int y)
        {
            this.Position = this.Position + new Size(140, 150);
        }
        
    }
}
