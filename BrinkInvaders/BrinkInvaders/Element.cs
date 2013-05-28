﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public abstract class Element
    {

        private int width;
        private Color color;
        private Point position;

        public Element(int width, Point position)
        {
            this.width = width;
            this.position = position;
        }
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }


        public Color Color
        {
            get{ return color; }
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