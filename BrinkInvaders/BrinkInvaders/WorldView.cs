using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrickInvaders.Model;
namespace BrickInvaders
{
    namespace View
    {
       public abstract class WorldView : Observer

        {

           public abstract void Refresh(Observable o);
            
        }
    }
}