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
            private int id;
            private string pseudo;

            public Player(string pseudo, int id)
            {
                this.pseudo = pseudo;
                this.id = id;
            }
            public int Id
            {
                get { return id; }
            }

            public string Pseudo
            {
                get { return pseudo; }
                set { pseudo = value; }
            }

        }
    }
}
