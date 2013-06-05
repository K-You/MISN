using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;
using System.Windows.Forms;
using System.Drawing;

namespace BrickInvaders
{
    namespace View
    {

        public class BrickView : ElementView
        {

            public BrickView(Form f)
                : base(f)
            {
                this.Image = global::BrickInvaders.Properties.Resources.spaceinvader;
                this.BackColor = Color.Black;
                this.SizeMode = PictureBoxSizeMode.Zoom;
                this.Location = new Point(int.MinValue, int.MinValue);
            }

            public override void Refresh(Observable m)
            {
                base.Refresh(m);

                BasicBrick brick = (BasicBrick)m;

                if (brick.Health <= 0)
                {
                    this.Dispose();
                }
            }
        }
    }
}
