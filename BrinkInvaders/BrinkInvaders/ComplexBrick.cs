using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickInvaders
{

    namespace Model
    {

        public class ComplexBrick : BasicBrick
        {
            public ComplexBrick(Vector2D position, Vector2D speed) : base(position, speed) { }
        }
    }
}
