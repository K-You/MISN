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
                this.Image = global::BrickInvaders.Properties.Resources.spaceship;
                this.BackColor = Color.Black;
                this.SizeMode = PictureBoxSizeMode.StretchImage; // élargissement en fonction de la largeur du vaisseau
                
            }

            public override void Refresh(Observable m)
            {
                base.Refresh(m); //rafraichissement de position
                Ship ship = (Ship)m;

                

                    
              
            }
        }

    }
}
