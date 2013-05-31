using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using System.Timers;

namespace BrickInvaders
{

    namespace Controller
    {

        class Engine
        {
            private static int DEFAULT_INTERVAL = 1000 / 60; //Framerate de 60FPS
            private static Configuration _configuration;
            private static ModelInterface _model;
            private Timer _timer;

            public Engine(Configuration c, ModelInterface m)
            {
                Engine._configuration = c;
                Engine._model = m;
                this._timer = new Timer(DEFAULT_INTERVAL);
            }

            public void run()
            {
                this._timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                this._timer.Enabled = true;
            }

            private static void OnTimedEvent(object source, ElapsedEventArgs e)
            {

                ModelInterface m = Engine._model;
                int length = m.GetBallCount();
                int length2 = m.GetBrickCount();

                Ball b;
                BasicBrick bb;

                for (int i = 0; i < length; i++)
                {

                    b = m.GetBall(i);
                    for (int j = 0; j < length2; j++)
                    {
                        bb = m.GetBrick(j);
                        if (Tools.Utils.Intersects(bb.BoundingBox, b.BoundingBox))
                        {
                            bb.Health -= b.Damage;
                            //TODO use elastic choc > check the way the objects move
                            Tools.Utils.ChocResult(b, bb);
                            b.Speed += bb.Speed;
                        }
                    }
                    b.Position += b.Speed;
                }

                //TODO what about ball between-ball collisions?
            }
        }
    }
}
