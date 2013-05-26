using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public interface WorldView
    {
        void refresh(WorldModel m);
    }
}
