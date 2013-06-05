using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{

    namespace Model
    {

        public class Player
        {
            private string _pseudo;

            public Player(string pseudo)
            {
                this._pseudo = pseudo;
            }

            public string Pseudo
            {
                get { return _pseudo; }
                set { _pseudo = value; }
            }

        }
    }
}
