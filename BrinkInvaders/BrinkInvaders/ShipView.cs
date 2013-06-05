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
                this.BackColor = Color.YellowGreen;
                this.Width = 0;
                
            }

            public override void Refresh(Observable m)
            {
                base.Refresh(m);
                Ship ship = (Ship)m;

                this.BackColor = ship.Color; 
                this.form.Controls.Add(new Label(){Text=ship.Color.ToString(),BackColor = Color.Yellow,Location = new Point(100,100)});

                    
                this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

    }
}
