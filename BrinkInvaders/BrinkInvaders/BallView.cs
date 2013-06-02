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

        public class BallView : ElementView
        {

            public BallView(WorldView v):base(v)
            {
                this.Image = global::BrickInvaders.Properties.Resources.ball;
                this.SizeMode = PictureBoxSizeMode.Zoom;
            }

            public BallView():base()
            { }

            public void Refresh(Observable o)
            {
                
            }
        }

    }
}
