using BrickInvaders.Controller;
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
            private GameMode mode;

            public Score(Player player, int value,GameMode mode)
            {
                this.player = player;
                this.Value = value;
                this.mode = mode;
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

            public GameMode Mode
            {
                get { return mode; }
                set { mode = value; }
            }

            public int CompareTo(Score sc)
            {
                if(sc.Value<this.Value){
                    return 1;
                }
                else if (sc.Value > this.Value)
                {
                    return -1;
                }
                return 0;
            }
        }
    }
}