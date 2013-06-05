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
    public class BrickInvaders
    {
        public static MainFrame _frame;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BrickInvaders._frame = new MainFrame();

            Launcher launcher = new Launcher();
            Application.Run(launcher);

            Configuration c = launcher.Configuration;

            if (c != null)
            {
                Player p = new Player(launcher.Pseudo);
                ModelInterface m = new GameModel();
                m.SetScoresModel(new ScoresModel(c.GameMode));
                m.AddObserver(BrickInvaders._frame);

                Engine.Initialise(p, c, m, BrickInvaders._frame);

                Application.Run(BrickInvaders._frame);
            }
        }
    }
}
