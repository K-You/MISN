using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Controller;
using BrickInvaders.View;

namespace BrickInvaders
{

    namespace Model
    {

        class Game : Observable
        {
            private int _time;
            private int _brokenBriks;
            private Map _map;
            private Player _player;
            private int _level;
            private Configuration _configuration;

            public Map Map
            {
                get { return _map; }
                set { _map = value; }
            }

            public Configuration Configuration
            {
                get { return _configuration; }
                set { _configuration = value; }
            }

            public int Level
            {
                get { return _level; }
                set { _level = value; }
            }

            public Player Player
            {
                get { return _player; }
                set { _player = value; }
            }

            public int BrokenBriks
            {
                get { return _brokenBriks; }
                set { _brokenBriks = value; }
            }

            public int Time
            {
                get { return _time; }
                set { _time = value; }
            }

            public override void NotifyObservers()
            {
                foreach (Observer v in this._observers)
                {
                    v.Refresh(this);
                }
            }
        }
    }
}
