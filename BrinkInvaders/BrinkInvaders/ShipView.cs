using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using System.Windows.Forms;

namespace BrickInvaders
{

    namespace View
    {

        public class ShipView : ElementView
        {
            public ShipView():base()
            { }
            public ShipView(Form f)
                : base(f)
            { 
            }

            public override void Refresh(Observable m)
            {
                base.Refresh(m);
                Ship ship = (Ship)m;

                this.BackColor = ship.Color;
                this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

    }
}
