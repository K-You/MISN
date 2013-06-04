using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BrickInvaders.Model;
using BrickInvaders.Controller;
using BrickInvaders.View;

namespace BrickInvaders
{
    class BrickInvaders
    {
        public static MainFrame frame;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BrickInvaders.frame = new MainFrame();

            Launcher launcher = new Launcher();
            Application.Run(launcher); 

            Configuration c = launcher.Configuration;

            if (c != null) {
                Player p = new Player(launcher.Pseudo);
                ModelInterface m = new GameModel();
                m.AddObserver(BrickInvaders.frame);

                Engine e = new Engine(p, c, m, BrickInvaders.frame);

                WorldView view = new GameMapView(BrickInvaders.frame);

                Application.Run(BrickInvaders.frame);
            }            
        }
    }
}
