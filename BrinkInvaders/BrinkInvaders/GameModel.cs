using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Controller;

namespace BrickInvaders
{
    namespace Model
    {

        class GameModel : ModelInterface
        {
            private int _time;
            private int _brokenBriks;
            private Map _map;
            private Player _player;
            private int _level;

            public GameModel()
            {
                this._map = new Map();
            }

            public void SetPlayer(Player p)
            {
                this._player = p;
            }

            public void SetBricks(List<BasicBrick> l)
            {
                this._map.Bricks = l;
            }

            public void SetShip(Ship s)
            {
                this._map.Ship = s;
            }

            public int GetLevel()
            {
                return this._level;
            }

            public int GetBallCount()
            {
                return this._map.Balls.Count;
            }

            public Rectangle GetBallBoundingBox(int index)
            {
                return this._map.Balls[index].BoundingBox;
            }

            public int GetBrickCount()
            {
                return this._map.Bricks.Count;
            }

            public Rectangle GetBrickBoundingBox(int index)
            {
                return this._map.Bricks[index].BoundingBox;
            }

            public void moveBall(int index)
            {
                this._map.Balls[index].Move();
            }
        }

    }
}
