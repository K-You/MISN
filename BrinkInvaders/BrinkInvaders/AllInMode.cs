﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{

    namespace Controller
    {

        class AllInMode:GameMode
        {
            public AllInMode()
                : base(new BasicMapGenerator(), "AllIn mode")
            {

            }
        }

    }
}
