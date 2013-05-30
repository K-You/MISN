﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;
using BrickInvaders.Controller;
using System.Windows.Forms;

namespace BrickInvaders
{

    class BrickInvaders
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Launcher launcher = new Launcher();
            Application.Run(launcher); 

          //  GameMode g = new BasicMode();
          //  KeyBinding k = new KeyBinding();
            Configuration c = launcher.Configuration;

            Player p = new Player("Red the moine");
            ModelInterface m = new GameModel();
            c.InitialiseModel(m); 
            m.SetPlayer(p);

            Engine e = new Engine(c, m);
            e.run();
        }

    }
}
