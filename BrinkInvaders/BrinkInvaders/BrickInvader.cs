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

            // On crée la mainframe mais on ne l'affichage pas encore
            BrickInvaders._frame = new MainFrame();

            // On crée le launcher et on le lance
            Launcher launcher = new Launcher();
            Application.Run(launcher);

            // On récupère la configuration qui en est issue
            Configuration c = launcher.Configuration;

            // Si elle existe (le launcher n'a pas été fermé mais on l'a validé)
            if (c != null)
            {
                // On crée le joueur et le modèle du jeu, on charge les scores associés, la mainframe surveillera le modèle pour détecter la défaite entre autre
                Player p = new Player(launcher.Pseudo);
                ModelInterface m = new GameModel();
                m.SetScoresModel(new ScoresModel(c.GameMode));
                m.AddObserver(BrickInvaders._frame);

                // On initialise le contrôleur
                Engine.Initialise(p, c, m, BrickInvaders._frame);

                // On lance l'application depuis la mainframe
                Application.Run(BrickInvaders._frame);
            }
        }
    }
}
