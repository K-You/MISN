using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrinkInvaders
{
    public abstract class ElementView:Image
    {
        public Color MyProperty { get; set; };
        public Point Center {get;set};


    }
}
