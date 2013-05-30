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

                Rectangle br, b;

                for (int i = 0; i < length; i++)
                {
                    b = m.GetBallBoundingBox(i);
                    for (int j = 0; j < length2; j++)
                    {
                        br = m.GetBrickBoundingBox(j);
                        if (Tools.Utils.intersects(br, b))
                        {
                            m.DamageBrick(j, m.GetBallDamage(i));

                            //TODO use elastic choc > check the way the objects move
                            m.SetBallSpeed(i, m.GetBallSpeed(i) + m.GetBrickSpeed(j));
                        }
                    }
                    m.moveBall(i);
                }

                //TODO what about ball between-ball collisions?
            }
        }
    }
}
