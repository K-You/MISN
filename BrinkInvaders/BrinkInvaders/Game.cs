using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    class Game : WorldModel
    {
        private int _time;
        private int _brokenBriks;
        private List<BasicBrick> _list;
        private List<Ball> _balls;
        private Ship _ship;
        private Player _player;
        private int _level;
        private Configuration _configuration;

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
        

        public Ship Ship
        {
            get { return _ship; }
            set { _ship = value; }
        }
        

        public List<Ball> Balls
        {
            get { return _balls; }
            set { _balls = value; }
        }
        

        public List<BasicBrick> MyProperty
        {
            get { return _list; }
            set { _list = value; }
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
        

        public override void notifyObservers()
        {
            foreach (WorldView v in this._observers) {
                v.refresh(this);
            }
        }
    }
}
