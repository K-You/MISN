using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{
    namespace Controller
    {

        class HighSpeedMode : GameMode
        {
            public HighSpeedMode()
                : base(new BasicMapGenerator(), "HighSpeed mode")
            {

            }
        }
    }
}
