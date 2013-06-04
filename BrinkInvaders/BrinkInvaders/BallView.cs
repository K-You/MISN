using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;
using System.Drawing;
using System.Windows.Forms;

namespace BrickInvaders
{

    namespace View
    {

        public class BallView : ElementView
        {

            public BallView(Form f):base(f)
            {
                this.Image = global::BrickInvaders.Properties.Resources.windows_logo;
                
                this.SizeMode = PictureBoxSizeMode.Zoom;
            }

            public override void Refresh(Observable o)
            {
                base.Refresh(o);
                this.BackColor = Color.Transparent;
                
            }
        }
    }
}
