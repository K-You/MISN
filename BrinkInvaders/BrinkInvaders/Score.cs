using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{

    namespace Model
    {

        public class Score
        {

            private Player player;
            private int val;

            public Score(Player player, int value)
            {
                this.player = player;
                this.Value = value;
            }

            public int Value
            {
                get { return val; }
                set { val = value; }
            }


            public Player Player
            {
                get { return player; }
                set { player = value; }
            }
        }
    }
}