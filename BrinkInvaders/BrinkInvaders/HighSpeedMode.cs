﻿using BrickInvaders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{
    namespace Controller
    {

        public class HighSpeedMode : GameMode
        {
            public HighSpeedMode()
                : base(new BasicMapGenerator(false), "HighSpeed mode", new Vector2D(0, -0.005), new Vector2D(0, -0.0005))
            {
            }
        }
    }
}
