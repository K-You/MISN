﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using BrickInvaders.View;

namespace BrickInvaders
{

    namespace Model
    {

        public class Ship : DynamicElement
        {
            private string label;
            private int health;

            private static Vector2D DEFAULT_POSITION = new Vector2D();
            private static Vector2D DEFAULT_SPEED = new Vector2D();
            private static Vector2D DEFAULT_DIMENSIONS = new Vector2D(1,1);
            private static int DEFAULT_MASS = int.MaxValue;
            private static Color DEFAULT_COLOR = Color.Black;

            public Ship(string label)
                : this(label, DEFAULT_POSITION, DEFAULT_SPEED, DEFAULT_DIMENSIONS, DEFAULT_MASS, DEFAULT_COLOR)
            {
            }

            public Ship(string label, Vector2D position)
                : this(label, position, DEFAULT_SPEED, DEFAULT_DIMENSIONS, DEFAULT_MASS, DEFAULT_COLOR)
            {
            }

            public Ship(string label, Vector2D position, Vector2D speed, Vector2D dimensions,  int mass, Color color)
                : base(position, speed, dimensions, mass, color)
            {
                this.label = label;
                this.AddObserver(new ShipView(BrickInvaders.frame));
            }

            public int Health
            {
                get { return health; }
                set { health = value; this.NotifyObservers(); }
            }

            public string Label
            {
                get { return label; }
                set { label = value; this.NotifyObservers(); }
            }

            public override void NotifyObservers()
            {
                foreach (Observer obs in this._observers)
                {
                    obs.Refresh(this);
                }
            }

        }
    }
}