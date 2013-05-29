using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        public interface MapGenerator
        {
            List<BasicBrick> generateMap(int level, int width, int height);
            Ship generateShip();
        }
    }
}