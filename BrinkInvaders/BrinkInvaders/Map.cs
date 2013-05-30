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

            public Map() : this(new List<BasicBrick>(), new List<Ball>()) { }

            public Map(List<BasicBrick> bricks, List<Ball> balls)
            {
                this.Bricks = bricks;
                this.Balls = balls;
            }

        }
    }
}
