using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{
    namespace View
    {
        public interface Observer
        {
            void refresh(Observable m);
        }
    }
}
