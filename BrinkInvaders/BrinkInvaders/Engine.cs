﻿using System;
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
            private static Engine INSTANCE = null;

            private int DEFAULT_INTERVAL = 1000 / 24; // Framerate de 24 IPS
            private Configuration _configuration;
            private ModelInterface _model;
            private Player _player;
            private System.Timers.Timer _timer;

            public static void Initialise(Player p, Configuration c, ModelInterface m, MainFrame form)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Engine(p, c, m, form);
                }
            }

            // On applique un pattern singleton, il n'y a qu'un seul Engine qui modifiera le modèle
            public static Engine GetInstance()
            {
                return INSTANCE;
            }

            private Engine(Player p, Configuration c, ModelInterface m, MainFrame form)
            {
                this._player = p;
                this._configuration = c;
                this._model = m;

                form.Engine = this;

                this._timer = new System.Timers.Timer(DEFAULT_INTERVAL);
                this._timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                this._timer.SynchronizingObject = form;
            }

            public void Restart()
            {
                this.Stop();
                this.Start();
            }

            public void Start()
            {
                this._configuration.InitialiseModel(this._model);
                this._model.SetPlayer(this._player);
                this.Run();
            }

            public void Stop()
            {
                this._model.SetStopped(true);
                if (this._model.IsLost())
                {
                    this._model.AddScore(this._model.GetPlayer(), (int)Math.Pow((double)this._model.GetDestroyedBricks(),3), this._configuration.GameMode);
                }
                this._timer.Stop();
            }

            public void Run()
            {
                this._timer.Start();
            }

            private static void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                ModelInterface m = Engine.GetInstance()._model;
                int length = m.GetBallCount();
                int length2 = m.GetBrickCount();

                Vector2D msize = m.GetMapDimensions();
                Vector2D shipPosition = m.GetShipPosition();
                Vector2D fallSpeed = (length2 > 0) ? m.GetBrickSpeed(0) : null;

                Random r = new Random();
                double diff;

                Vector2D bposition, newPosition, newSpeed, bspeed;
                int j, health;
                bool chocked;
                
                // S'il n'y a plus de briques, on passe au niveau suivant
                if (length2 <= 0)
                {
                    m.SetLevel(m.GetLevel() + 1);
                    Engine.GetInstance().Restart();
                }

                // Pour chaque balle (car le moteur gère plusieurs balles même si on l'a limité pour la démonstration)
                for (int i = 0; i < length; i++)
                {
                    bspeed = m.GetBallSpeed(i);
                    j = 0;
                    chocked = false;
                    while (j < length2 && !chocked)
                    {
                        if (Tools.Utils.Intersects(m.GetBallBoundingBox(i), m.GetBrickBoundingBox(j)))
                        {
                            health = m.GetBrickHealth(j) - m.GetBallDamage(i);
                            m.SetBrickHealth(j, health);
                            if (health <= 0)
                            {
                                // Il faut corriger l'index car la brique va être supprimée dans le setbrickhealth
                                j--;
                                length2--;
                            }

                            // Le rebond est géré dans une classe utilitaire, ici on inverse X et Y
                            m.SetBallSpeed(i, Tools.Utils.ChocResult(bspeed));
                            chocked = true;
                        }
                        j++;
                    }

                    bposition = m.GetBallPosition(i);
                    newPosition = bposition + bspeed;
                    newSpeed = bspeed;

                    // On surveille que la balle ne soit pas sur le point de sortir de l'écran et on corrige par des rebonds sinon
                    if (newPosition.X < 0)
                    {
                        newPosition.invertX();
                        newSpeed.invertX();
                    }
                    else if (newPosition.X >= msize.X - 1)
                    {
                        newPosition.X = 2 * (msize.X - 1) - newPosition.X;
                        newSpeed.invertX();
                    }
                    else if (newPosition.Y >= msize.Y - 1)
                    {
                        newPosition.Y = 2 * (msize.Y - 1) - newPosition.Y;
                        newSpeed.invertY();
                    }
                    // La balle peut aussi rebondir sur le ship, nous le testons, si c'est le cas elle rebondit avec un petit aléa (diff)
                    else if (Tools.Utils.Intersects(m.GetBallBoundingBox(i), m.GetShipBoundingBox()))
                    {
                        newPosition.Y = 2 * (shipPosition.Y + m.GetShipDimensions().Y) - newPosition.Y;
                        newSpeed.invertY();

                        diff = r.NextDouble() / 2 * newSpeed.X * ((r.Next(2) < 1) ? -1 : 1);

                        newSpeed.X += diff;
                    }

                    m.SetBallPosition(i, newPosition);
                    m.SetBallSpeed(i, newSpeed);

                    // Si on a perdu la balle, on perd la partie
                    if (newPosition.Y < 0)
                    {
                        m.SetLost(true);
                        Engine.GetInstance().Stop();
                    }
                }

                // On va accélérer les briques en mode HighSpeedMode et aussi les déplacer
                for (j = 0; j < length2; j++)
                {
                    newSpeed = fallSpeed + Engine.GetInstance()._configuration.GameMode.StepSpeed;
                    newPosition = m.GetBrickPosition(j) + m.GetBrickSpeed(j);
                    m.SetBrickPosition(j, newPosition);
                    m.SetBrickSpeed(j, newSpeed);

                    if (newPosition.Y < -1)
                    {
                        j--;
                        length2--;
                    }
                }

                // Enfin si le ship touche une brique, il la détruit mais est endommagé, s'il est détruit, on perd
                for (j = 0; j < length2; j++)
                {
                    if (Tools.Utils.Intersects(m.GetShipBoundingBox(), m.GetBrickBoundingBox(j)))
                    {
                        m.SetShipHealth(m.GetShipHealth() - m.GetBrickHealth(j));

                        if (m.GetShipHealth() <= 0)
                        {
                            m.SetLost(true);
                            Engine.GetInstance().Stop();
                        }

                        m.SetBrickHealth(j, 0);
                        j--;
                        length2--;
                    }
                }
            }

            internal void CaptureKey(object sender, KeyEventArgs e)
            {
                ModelInterface m = Engine.GetInstance()._model;
                int key = e.KeyValue;
                if (key == Engine.GetInstance()._configuration.Keys.GetKey("left"))
                {
                    Vector2D newPos = m.GetShipPosition() - m.GetShipSpeed();
                    m.SetShipPosition((newPos.X > 0) ? newPos : new Vector2D(0, newPos.Y));
                }
                else if (key == Engine.GetInstance()._configuration.Keys.GetKey("right"))
                {
                    Vector2D newPos = m.GetShipPosition() + m.GetShipSpeed();
                    int maxX = (int)m.GetMapDimensions().X;
                    int width = (int)m.GetShipDimensions().X;
                    m.SetShipPosition((newPos.X < maxX - width) ? newPos : new Vector2D(maxX - width, newPos.Y));
                }
                else if (key == Engine.GetInstance()._configuration.Keys.GetKey("esc"))
                {
                    m.SetExited(true);
                }
            }
        }
    }
}
