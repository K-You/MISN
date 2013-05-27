using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public interface MapGenerator
    {
        List<BasicBrick> generateMap(int level);
        Ship generateShip();
    }
}
