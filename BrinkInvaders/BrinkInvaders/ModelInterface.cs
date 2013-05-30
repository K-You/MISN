using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Model
    {

        interface ModelInterface
        {
            void SetPlayer(Player p);
            void SetBricks(List<BasicBrick> l);
            void SetShip(Ship s);

            int GetLevel();
            
            int GetBallCount();
            Rectangle GetBallBoundingBox(int index);

            int GetBrickCount();
            Rectangle GetBrickBoundingBox(int index);

            void moveBall(int index);
        }
    }
}
