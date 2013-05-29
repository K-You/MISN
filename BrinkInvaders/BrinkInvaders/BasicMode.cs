using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{

    namespace Controller
    {

        public class BasicMode : GameMode
        {
            public BasicMode()
                : base(new BasicMapGenerator(), "Easy mode")
            {

            }
        }

    }
}
