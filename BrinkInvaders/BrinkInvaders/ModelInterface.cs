using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Model
    {

        public interface ModelInterface
        {
            void SetBricks(List<BasicBrick> l);
            void SetShip(Ship s);

            int GetBallCount();
            Rectangle GetBallBoundingBox(int index);
            Vector2D GetBallSpeed(int index);
            void SetBallSpeed(int index, Vector2D speed);
            int GetBallDamage(int index);

            int GetBrickCount();
            Rectangle GetBrickBoundingBox(int index);
            Vector2D GetBrickSpeed(int index);

            void DamageBrick(int index, int damage);
            void moveBall(int index);

            //SCORE PART
            int GetDestroyedBricks();
            long GetPassedSeconds();

            void SetPlayer(Player p);
            Player GetPlayer();

            int GetLevel();
        }
    }
}
