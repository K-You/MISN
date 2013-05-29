using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    class Map
    {
        public List<BasicBrick> Bricks { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Ship> Ships { get; set; }
        public List<Ball> Balls { get; set; }


        public Map(int height, int width, List<BasicBrick> bricks, List<Ship> ships, List<Ball> balls)
        {
            this.Height = height;
            this.Width = width;
            this.Bricks = bricks;
            this.Ships = ships;
            this.Balls = balls;
        }
        public Map(int height, int width) : this(height, width, new List<BasicBrick>(), new List<Ship>(), new List<Ball>()) { }
        public Map():this(0,0){}
    }
}
