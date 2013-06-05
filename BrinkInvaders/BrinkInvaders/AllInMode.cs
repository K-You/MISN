using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        class AllInMode : GameMode
        {
            public AllInMode()
                : base(new BasicMapGenerator(), "AllIn mode", new Vector2D(0, -0.005), new Vector2D(0, -0.005))
            {

            }
        }

    }
}
