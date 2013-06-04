﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using System.Drawing;

namespace BrickInvaders
{

    namespace Model
    {

        public abstract class ModelInterface : Observable
        {
            public abstract Vector2D GetMapDimensions();
            public abstract void SetMapDimensions(Vector2D dimensions);

            public abstract void SetBricks(List<BasicBrick> l);
            public abstract void SetShip(Ship s);
            public abstract void AddBall();

            public abstract int GetBallCount();

            public abstract Vector2D GetBallSpeed(int index);
            public abstract int GetBallDamage(int index);
            public abstract int GetBallMass(int index);
            public abstract Vector2D GetBallPosition(int index);
            public abstract Rectangle GetBallBoundingBox(int index);
            public abstract Color GetBallColor(int index);

            public abstract void SetBallPosition(int index, Vector2D position);
            public abstract void SetBallSpeed(int index, Vector2D speed);

            public abstract int GetBrickCount();

            public abstract Vector2D GetBrickSpeed(int index);
            public abstract int GetBrickHealth(int index);
            public abstract int GetBrickMass(int index);
            public abstract Vector2D GetBrickPosition(int index);
            public abstract Rectangle GetBrickBoundingBox(int index);
            public abstract Vector2D GetBrickDimensions(int index);
            public abstract Color GetBrickColor(int index);

            public abstract void SetBrickHealth(int index, int health);
            public abstract void SetBrickPosition(int index, Vector2D position);

            public abstract Rectangle GetShipBoundingBox();
            public abstract Vector2D GetShipPosition();
            public abstract Vector2D GetShipSpeed();
            public abstract Vector2D GetShipDimensions();
            public abstract void SetShipSpeed(Vector2D speed);
            public abstract void SetShipPosition(Vector2D position);

            public abstract Color GetShipColor();

            public abstract int GetShipHealth();
            public abstract void SetShipHealth(int health);

            //SCORE PART
            public abstract int GetDestroyedBricks();
            public abstract long GetPassedSeconds();

            public abstract void SetPlayer(Player p);
            public abstract Player GetPlayer();

            public abstract int GetLevel();
        }
    }
}
