using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;
using BrickInvaders.View;
namespace BrickInvaders
{
    namespace View
    {


        public abstract class ElementView : Observer
        {
            public WorldView worldWiew { get; set; }



            public ElementView(WorldView W)
            {

            }
            public abstract void Refresh(Observable o);

        }
    }

}
