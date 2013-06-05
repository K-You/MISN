using BrickInvaders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{
    namespace Model
    {
        class Map
        {
            public List<BasicBrick> Bricks { get; set; }
            public Ship Ship { get; set; }
            public List<Ball> Balls { get; set; }

            private int _height;
            private int _width;

            public Map() : this(new List<BasicBrick>(), new List<Ball>()) { }

            public Map(List<BasicBrick> bricks, List<Ball> balls)
            {
                this.Bricks = bricks;
                this.Balls = balls;
            }

            public int Width
            {
                get { return _width; }
                set { _width = value; }
            }

            public int Height
            {
                get { return _height; }
                set { _height = value; }
            }
        }
    }
}
