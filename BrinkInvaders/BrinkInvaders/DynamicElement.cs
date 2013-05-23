﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    public abstract class DynamicElement : Element
    {
        private int speed;

        public DynamicElement(int speed, int width, Color color, Point position):base(width, color, position)
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
