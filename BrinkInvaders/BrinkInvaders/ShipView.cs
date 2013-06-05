using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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
                this.Width = 0;
            }

            public override void Refresh(Observable m)
            {
                base.Refresh(m);
                Ship ship = (Ship)m;

                this.BackColor = Color.White; ;
                this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

    }
}
