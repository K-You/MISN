using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;

namespace BrickInvaders
{
    namespace View
    {

        public class BrickView : ElementView
        {

            public BrickView()
            { }
            public override void Refresh(Observable m)
            {
                BasicBrick brick = (BasicBrick)m;
                this.BackColor = brick.Color;
            }
        }

    }

}
