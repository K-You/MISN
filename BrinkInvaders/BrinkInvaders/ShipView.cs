using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace View
    {

        public class ShipView : Observer
        {

            public void Refresh(Model.Observable m)
            {
                Ship ship = (Ship)m;

            }
        }

    }
}
