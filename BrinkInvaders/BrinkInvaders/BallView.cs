﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace View
    {

        public class BallView : Observer
        {
            public void refresh(Observable o)
            {
                if (o is Ball)
                { 
                
                
                }
            }
        }

    }
}
