using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace View
    {

        public class ShipView : ElementView
        {
            public ShipView():base()
            { }
            public ShipView(WorldView v)
                : base(v)
            { 
            }

            public override void Refresh(Model.Observable m)
            {
                Ship ship = (Ship)m;

            }
        }

    }
}
