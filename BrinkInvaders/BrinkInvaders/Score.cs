using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public class Score
    {

        private Player player;
        private int val;
    //    private GameMode gameMode;

    //    public GameMode GameMode
    //    {
    //        get { return gm; }
    //        set { gm = value; }
    //    } 

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
