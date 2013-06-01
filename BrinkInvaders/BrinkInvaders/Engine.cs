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

                Vector2D bspeed, bbspeed;
                bool chocked;
                int j;

                for (int i = 0; i < length; i++)
                {
                    bspeed = m.GetBallSpeed(i);
                    j = 0;
                    chocked = false;
                    while (j < length2 && !chocked)
                    {
                        if (Tools.Utils.Intersects(m.GetBallBoundingBox(i), m.GetBrickBoundingBox(j)))
                        {
                            chocked = true;
                            bbspeed = m.GetBrickSpeed(j);
                            m.SetBrickHealth(j, m.GetBrickHealth(j) - m.GetBallDamage(i));
                            //TODO use elastic choc > check the way the objects move
                            m.SetBallSpeed(i, Tools.Utils.ChocResult(bspeed, m.GetBallMass(i), bbspeed, m.GetBrickMass(j)));
                        }
                        j++;
                    }
                    m.SetBallPosition(i, m.GetBallPosition(i) + bspeed);
                }

                //TODO what about ball between-ball collisions?
            }
        }
    }
}
