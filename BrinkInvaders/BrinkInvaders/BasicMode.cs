using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

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
