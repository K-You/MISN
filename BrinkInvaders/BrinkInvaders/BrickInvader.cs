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
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Launcher launcher = new Launcher();
            Application.Run(launcher); 

            try
            {
                Configuration c = launcher.Configuration;

                Player p = new Player(launcher.Pseudo);
                ModelInterface m = new GameModel();
                Engine e = new Engine(p, c, m);

                MainFrame frame = new MainFrame(e);
                WorldView view = new GameMapView(frame);
                m.AddObserver(view);

                Application.Run(frame);
            }
            catch (NullReferenceException)
            {
            }            
        }
    }
}
