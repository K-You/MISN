using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public class BasicMode:GameMode
    {
        public BasicMode():base(new BasicMapGenerator(),"Easy mode")
        {

        }
    }
}
