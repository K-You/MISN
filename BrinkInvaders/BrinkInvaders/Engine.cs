using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using System.Timers;
using BrickInvaders.View;
using System.Windows.Forms;

namespace BrickInvaders
{

    namespace Controller
    {

        public class Engine
        {
            private static int DEFAULT_INTERVAL = 1000 / 24;
            private static Configuration _configuration;
            private static ModelInterface _model;
            private static Player _player;
            private static System.Timers.Timer _timer;

            public Engine(Player p, Configuration c, ModelInterface m, MainFrame form)
            {
                Engine._player = p;
                Engine._configuration = c;
                Engine._model = m;

                form.Engine = this;

                Engine._timer = new System.Timers.Timer(DEFAULT_INTERVAL);
                Engine._timer.SynchronizingObject = form;
            }

            public void start()
            {
                Engine._configuration.InitialiseModel(Engine._model);
                Engine._model.SetPlayer(Engine._player);
                this.run();
            }

            public void run()
            {
                Engine._timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                Engine._timer.Start();
            }



            private static void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                ModelInterface m = Engine._model;
                int length = m.GetBallCount();
                int length2 = m.GetBrickCount();

                Vector2D msize = m.GetMapDimensions();
                Vector2D shipPosition = m.GetShipPosition();

                Vector2D bposition, newPosition, newSpeed, bspeed, bbspeed;
                int j, health;
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

                            health = m.GetBrickHealth(j) - m.GetBallDamage(i);
                            m.SetBrickHealth(j, health);
                            if (health <= 0)
                            {
                                j--;
                                length2--;
                            }

                            m.SetBallSpeed(i, Tools.Utils.ChocResult(bspeed));
                            chocked = true;
                        }
                        j++;
                    }

                    bposition = m.GetBallPosition(i);
                    newPosition = bposition + bspeed;
                    newSpeed = bspeed;
                    if (newPosition.X < 0)
                    {
                        newPosition.invertX();
                        newSpeed.invertX();
                    }
                    else if (newPosition.X >= msize.X - 1)
                    {
                        newPosition.X = 2 * msize.X - newPosition.X - 1;
                        newSpeed.invertX();
                    }
                    else if (newPosition.Y >= msize.Y - 1)
                    {
                        newPosition.Y = 2 * msize.Y - newPosition.Y - 1;
                        newSpeed.invertY();
                    }
                    else if (Tools.Utils.Intersects(m.GetBallBoundingBox(i), m.GetShipBoundingBox()))
                    {
                        //PRENDRE EN COMPTE LES ANGLES POUR LE REBOND

                        newPosition.Y = 2 * shipPosition.Y - newPosition.Y;
                        newSpeed.invert();
                    }

                    m.SetBallPosition(i, newPosition);
                    m.SetBallSpeed(i, newSpeed);

                    if (newPosition.Y < 0)
                    {
                       Engine.stop();
                    }
                    //SI LA BALLE SORT PAR LE BAS C'EST PERDU!
                }

                for (j = 0; j < length2; j++)
                {
                    newPosition = m.GetBrickPosition(j) + m.GetBrickSpeed(j);
                    m.SetBrickPosition(j, newPosition);

                    if (newPosition.Y < -1)
                    {
                        j--;
                        length2--;
                    }

                    if (Tools.Utils.Intersects(m.GetShipBoundingBox(), m.GetBrickBoundingBox(j)))
                    {
                        m.SetShipHealth(m.GetShipHealth() - m.GetBrickHealth(j));

                        if (m.GetShipHealth() <= 0)
                        {
                            Engine.stop();
                        }

                        m.SetBrickHealth(j, 0);
                        j--;
                        length2--;
                    }
                }
            }

            internal void CaptureKey(object sender, KeyEventArgs e)
            {
                ModelInterface m = Engine._model;
                int key = e.KeyValue;
                if (key == Engine._configuration.Keys.GetKey("left"))
                {
                    Vector2D newPos = m.GetShipPosition() - m.GetShipSpeed();
                    m.SetShipPosition((newPos.X > 0) ? newPos : new Vector2D(0, newPos.Y));
                }
                else if (key == Engine._configuration.Keys.GetKey("right"))
                {
                    Vector2D newPos = m.GetShipPosition() + m.GetShipSpeed();
                    int maxX = (int)m.GetMapDimensions().X;
                    int width = (int)m.GetShipDimensions().X;
                    m.SetShipPosition((newPos.X < maxX - width) ? newPos : new Vector2D(maxX - width, newPos.Y));
                }
                else if (key == Engine._configuration.Keys.GetKey("space"))
                {
                    if (m.GetBallCount() < 1)
                    {
                        m.AddBall();
                    }
                }
                else if (key == Engine._configuration.Keys.GetKey("esc"))
                {
                    //PAUSE/CONTROLS
                }
            }

            internal static void stop()
            {
                Engine._model.stop();
                Engine._model.AddScore(Engine._model.GetPlayer(), Engine._model.GetDestroyedBricks(), Engine._configuration.GameMode);
                Engine._timer.Stop();
            }
        }
    }
}
