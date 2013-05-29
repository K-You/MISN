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

        public Map(int height,int width, List<BasicBrick> bricks)
        {
            this.Height = height;
            this.Width = width;
            this.Bricks = bricks;
        }

        public Map(int height, int width):this(height,width,new List<BasicBrick>()){}
        public Map():this(0,0){}
    }
}
