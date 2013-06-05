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

            private Player _player;
            private int _val;
            private GameMode _mode;

            public Score(Player player, int value,GameMode mode)
            {
                this._player = player;
                this.Value = value;
                this._mode = mode;
            }

            public int Value
            {
                get { return _val; }
                set { _val = value; }
            }


            public Player Player
            {
                get { return _player; }
                set { _player = value; }
            }

            public GameMode Mode
            {
                get { return _mode; }
                set { _mode = value; }
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