using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Controller;
using BrickInvaders.View;
using System.Drawing;

namespace BrickInvaders
{
    namespace Model
    {

        class GameModel : ModelInterface
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

            public override void SetBricks(List<BasicBrick> l)
            {
                this._map.Bricks = l;
                this.NotifyObservers();
            }

            public override void SetShip(Ship s)
            {
                this._map.Ship = s;
                this.NotifyObservers();
            }

            public override int GetBallCount()
            {
                return this._map.Balls.Count;
            }

            public override int GetBrickCount()
            {
                return this._map.Bricks.Count;
            }

            public override int GetDestroyedBricks()
            {
                return this._brokenBriks;
            }

            public override long GetPassedSeconds()
            {
                return this._time;
            }

            public override void SetPlayer(Player p)
            {
                this._player = p;
                this.NotifyObservers();
            }

            public override Player GetPlayer()
            {
                return this._player;
            }

            public override int GetLevel()
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

            public override Vector2D GetBallSpeed(int index)
            {
                return this._map.Balls[index].Speed;
            }

            public override int GetBallDamage(int index)
            {
                return this._map.Balls[index].Damage;
            }

            public override int GetBallMass(int index)
            {
                return this._map.Balls[index].Mass;
            }

            public override Vector2D GetBallPosition(int index)
            {
                return this._map.Balls[index].Position;
            }

            public override Rectangle GetBallBoundingBox(int index)
            {
                return this._map.Balls[index].BoundingBox;
            }

            public override void SetBallPosition(int index, Vector2D position)
            {
                this._map.Balls[index].Position = position;
                this.NotifyObservers();
            }

            public override void SetBallSpeed(int index, Vector2D speed)
            {
                this._map.Balls[index].Speed = speed;
                this.NotifyObservers();
            }

            public override Vector2D GetBrickSpeed(int index)
            {
                return this._map.Bricks[index].Speed;
            }

            public override int GetBrickHealth(int index)
            {
                return this._map.Bricks[index].Health;
            }

            public override int GetBrickMass(int index)
            {
                return this._map.Bricks[index].Mass;
            }

            public override Rectangle GetBrickBoundingBox(int index)
            {
                return this._map.Bricks[index].BoundingBox;
            }

            public override void SetBrickHealth(int index, int health)
            {
                this._map.Bricks[index].Health = health;
                this.NotifyObservers();
            }

            public override Vector2D GetBrickPosition(int index)
            {
                return this._map.Bricks[index].Position;
            }

            public override Vector2D GetBrickDimensions(int index)
            {
                Element e = this._map.Bricks[index];
                return new Vector2D(e.Width, e.Height);
            }

            public override Color GetBrickColor(int index)
            {
                return this._map.Bricks[index].Color;
            }

            public override Vector2D GetMapDimensions()
            {
                return new Vector2D(this._map.Width, this._map.Height) ;
            }

            public override void SetMapDimensions(Vector2D dimensions)
            {
                this._map.Width = (int)dimensions.X;
                this._map.Height = (int)dimensions.Y;
            }
        }
    }
}
