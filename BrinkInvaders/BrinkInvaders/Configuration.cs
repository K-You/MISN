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

        public int Width { get; set; }
        public int LevelHeight { get; set; }

        private KeyBinding keys;

        public KeyBinding Keys
        {
            get { return keys; }
            set { keys = value; }
        }

        public Configuration(GameMode gameMode,KeyBinding keys)
        {
            this.keys = keys;
            this.gameMode = gameMode;
        }
    }
}
