using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    class Configuration
    {
        private GameMode gameMode;

        public GameMode GameMode
        {
            get { return gameMode; }
            set { gameMode = value; }
        }

        private KeyBinding keys;

        public KeyBinding Keys
        {
            get { return keys; }
            set { keys = value; }
        }
        
        
    }
}
