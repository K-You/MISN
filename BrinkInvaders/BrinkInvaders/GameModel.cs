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
            }

            public void SetShip(Ship s)
            {
                this._map.Ship = s;
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

            public Vector2D GetBallSpeed(int index)
            {
                return this._map.Balls[index].Speed;
            }

            public void SetBallSpeed(int index, Vector2D speed)
            {
                this._map.Balls[index].Speed = speed;
            }

            public Vector2D GetBrickSpeed(int index)
            {
                return this._map.Bricks[index].Speed;
            }

            public void DamageBrick(int index, int damage)
            {
                BasicBrick b = this._map.Bricks[index];

                b.Health -= damage;
                if (b.Health <= 0)
                {
                    this._map.Bricks.Remove(b);
                    this._brokenBriks++;
                }
                
            }

            public int GetBallDamage(int index)
            {
                return this._map.Balls[index].Damage;
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
                throw new NotImplementedException();
            }
        }
    }
}
