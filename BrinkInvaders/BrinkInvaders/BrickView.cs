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

        public class BrickView : ElementView
        {

            public BrickView(Form f) : base(f)
            {
            }

            public override void Refresh(Observable m)
            {
                base.Refresh(m);

                BasicBrick brick = (BasicBrick)m;
                this.BackColor = brick.Color;
            }
        }

    }

}
