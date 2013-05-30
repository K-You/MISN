using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickInvaders
{

    namespace Model {

        public abstract class DynamicElement : Element
        {
            private Vector2D _speed;

            public DynamicElement(Vector2D position, Vector2D speed)
                : base(position)
            {
                this._speed = speed;
            }

            public Vector2D Speed
            {
                get { return _speed; }
                set { _speed = value; }
            }

            //TODO MAY BE CONTROLLER PART
            public void Move()
            {
                this.Position += this._speed;
            }
        }
    }
}


