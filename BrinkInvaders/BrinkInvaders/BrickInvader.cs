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

                Player p = new Player("Red the moine");
                ModelInterface m = new GameModel();
                c.InitialiseModel(m);
                m.SetPlayer(p);

                Engine e = new Engine(c, m);
                e.run();

                MainFrame frame = new MainFrame();
                WorldView view = new GameMapView(frame);
                Console.WriteLine("launch");
                Application.Run(frame);
            }
            catch (NullReferenceException)
            {
            }            
        }
    }
}
