using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    interface MapGenerator
    {
        public List<BasicBrick> generateMap(int level);
        public Ship generateShip();
    }
}
