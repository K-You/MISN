﻿using System;
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

        public class GameModel : ModelInterface
        {
            private ScoresModel _scores;
            private int _brokenBriks;
            private Map _map;
            private Player _player;
            private int _level = 1;
            private bool _lost = false;
            private bool _stopped = false;
            private bool _ended = false;

            public GameModel()
            {
                this._map = new Map();
            }

            public override void SetScoresModel(ScoresModel scModel)
            {
                this._scores = scModel;
            }
            public override void AddScore(Player player, int value, GameMode mode)
            {
                this._scores.AddScore(player, value, mode);
            }

            public override void SetBricks(List<BasicBrick> l)
            {
                this._map.Bricks = l;
                this.NotifyObservers();
            }

            public override void AddShip(ShipArguments s)
            {
                this._map.Ship = new Ship(s.Label, s.Position, s.Speed, s.Dimension, s.Mass, s.Health, s.Color);
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

            public override void SetLevel(int level)
            {
                this._level = level;
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
                if (index >= 0 && index < this._map.Bricks.Count)
                {
                    this._map.Bricks[index].Health = health;

                    if (health <= 0)
                    {
                        this._brokenBriks++;
                        this._map.Bricks.RemoveAt(index);
                    }

                    this.NotifyObservers();
                }
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
                return new Vector2D(this._map.Width, this._map.Height);
            }

            public override void SetMapDimensions(Vector2D dimensions)
            {
                this._map.Width = (int)dimensions.X;
                this._map.Height = (int)dimensions.Y;
                this.NotifyObservers();
            }

            public override Vector2D GetShipPosition()
            {
                if (this._map.Ship != null)
                {
                    return this._map.Ship.Position;
                }
                else
                {
                    return new Vector2D();
                }
            }

            public override Vector2D GetShipSpeed()
            {
                return this._map.Ship.Speed;
            }

            public override Vector2D GetShipDimensions()
            {
                if (this._map.Ship != null)
                {
                    return new Vector2D(this._map.Ship.Width, this._map.Ship.Height);
                }
                else
                {
                    return new Vector2D();
                }
            }

            public override void SetShipSpeed(Vector2D speed)
            {
                this._map.Ship.Speed = speed;
            }

            public override void SetShipPosition(Vector2D position)
            {
                this._map.Ship.Position = position;
                this.NotifyObservers();
            }

            public override int GetShipHealth()
            {
                return this._map.Ship.Health;
            }

            public override void SetShipHealth(int health)
            {
                this._map.Ship.Health = health;
            }

            public override Color GetBallColor(int index)
            {
                return this._map.Balls[index].Color;
            }

            public override Color GetShipColor()
            {
                if (this._map.Ship != null)
                {
                    return this._map.Ship.Color;
                }
                else
                {
                    return Color.White;
                }
            }

            public override void SetBrickPosition(int index, Vector2D position)
            {
                if (index >= 0 && index < this._map.Bricks.Count)
                {
                    this._map.Bricks[index].Position = position;

                    if (position.Y < -1)
                    {
                        this._brokenBriks++;
                        this._map.Bricks.RemoveAt(index);
                    }

                    this.NotifyObservers();
                }
            }

            public override Rectangle GetShipBoundingBox()
            {
                return this._map.Ship.BoundingBox;
            }

            public override void AddBall()
            {
                if (this._map.Ship != null)
                    this._map.Balls.Add(new Ball(this._map.Ship.Position + new Vector2D(0, 1), new Vector2D(0.25, 1) / 4, new Vector2D(1, 1), 1, 1));
            }

            public override void RemoveBalls()
            {
                this._map.Balls.Clear();
            }

            public override void SetStopped(bool stop)
            {
                this._stopped = stop;
                this.NotifyObservers();
            }

            public override bool IsStopped()
            {
                return this._stopped;
            }

            public override List<Score> GetScores(GameMode mode)
            {
                return this._scores.GetScores(mode);
            }

            public override bool IsEnded()
            {
                return this._ended;
            }

            public override void SetExited(bool exit)
            {
                this._ended = exit;
                this.NotifyObservers();
            }

            public override List<Score> GetScores()
            {
                return this._scores.GetScores();
            }

            public override void SetBrickSpeed(int index, Vector2D speed)
            {
                if (index >= 0 && index < this._map.Bricks.Count)
                    this._map.Bricks[index].Speed = speed;
            }

            public override void SetLost(bool lost)
            {
                this._lost = lost;
                this.NotifyObservers();
            }

            public override bool IsLost()
            {
                return this._lost;
            }
        }
    }
}
