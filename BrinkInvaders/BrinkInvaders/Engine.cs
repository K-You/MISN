using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using System.Timers;
using BrickInvaders.View;

namespace BrickInvaders
{

    namespace Controller
    {

        public class Engine
        {
            private static int DEFAULT_INTERVAL = 1000/24; //Framerate de 24FPS
            private static Configuration _configuration;
            private static ModelInterface _model;
            private static Player _player;
            private Timer _timer;

            public Engine(Player p, Configuration c, ModelInterface m, MainFrame form)
            {
                Engine._player = p;
                Engine._configuration = c;
                Engine._model = m;

                form.Engine = this;

                this._timer = new Timer(DEFAULT_INTERVAL);
                this._timer.SynchronizingObject = form;
            }

            public void start()
            {
                Engine._configuration.InitialiseModel(Engine._model);
                Engine._model.SetPlayer(Engine._player);
                this.run();
            }

            public void run()
            {
                this._timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                this._timer.Enabled = true;
            }

            private static void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                Console.WriteLine("tick");

                ModelInterface m = Engine._model;
                int length = m.GetBallCount();
                int length2 = m.GetBrickCount();

                Vector2D bspeed, bbspeed;
                int j;
                bool chocked;

                for (int i = 0; i < length; i++)
                {
                    bspeed = m.GetBallSpeed(i);
                    j = 0;
                    chocked = false;
                    while (j < length2 && !chocked)
                    {
                        if (Tools.Utils.Intersects(m.GetBallBoundingBox(i), m.GetBrickBoundingBox(j)))
                        {
                            bbspeed = m.GetBrickSpeed(j);
                            m.SetBrickHealth(j, m.GetBrickHealth(j) - m.GetBallDamage(i));
                            //TODO use elastic choc > check the way the objects move
                            m.SetBallSpeed(i, Tools.Utils.ChocResult(bspeed, m.GetBallMass(i), bbspeed, m.GetBrickMass(j)));
                            chocked = true;
                        }
                        j++;
                    }
                    m.SetBallPosition(i, m.GetBallPosition(i) + bspeed);
                }

                for (j = 0; j < length2; j++)
                {
                    m.SetBrickPosition(j, m.GetBrickPosition(j) + m.GetBrickSpeed(j));
                }
                //TODO what about ball between-ball collisions?
            }
        }
    }
}
