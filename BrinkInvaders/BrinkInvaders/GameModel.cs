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

        class GameModel : Observable, ModelInterface
        {
            private long _time;
            private int _brokenBriks;
            private Map _map;
            private Player _player;
            private int _level;

            public GameModel()
            {
                this._map = new Map();
            }

            public void SetBricks(List<BasicBrick> l)
            {
                this._map.Bricks = l;
                this.NotifyObservers();
            }

            public void SetShip(Ship s)
            {
                this._map.Ship = s;
                this.NotifyObservers();
            }

            public int GetBallCount()
            {
                return this._map.Balls.Count;
            }

            public Ball GetBall(int index)
            {
                return this._map.Balls[index];
            }

            public int GetBrickCount()
            {
                return this._map.Bricks.Count;
            }

            public BasicBrick GetBrick(int index)
            {
                return this._map.Bricks[index];
            }

            public int GetDestroyedBricks()
            {
                return this._brokenBriks;
            }

            public long GetPassedSeconds()
            {
                return this._time;
            }

            public void SetPlayer(Player p)
            {
                this._player = p;
                this.NotifyObservers();
            }

            public Player GetPlayer()
            {
                return this._player;
            }

            public int GetLevel()
            {
                return this._level;
            }

            public override void NotifyObservers()
            {
                foreach (Observer obs in this._observers)
                {
                    obs.Refresh(this);
                }
            }
        }
    }
}
