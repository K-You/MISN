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
            Ball GetBall(int index);

            int GetBrickCount();
            BasicBrick GetBrick(int index);

            //SCORE PART
            int GetDestroyedBricks();
            long GetPassedSeconds();

            void SetPlayer(Player p);
            Player GetPlayer();

            int GetLevel();
        }
    }
}
