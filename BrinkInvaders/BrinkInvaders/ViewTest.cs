using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using BrickInvaders.Model;
using BrickInvaders.Controller;
namespace BrickInvaders
{
    class ViewTest:Form
    {

         private void Form1_Load(object sender, EventArgs e)
        {
            GameMode g = new BasicMode();
            KeyBinding k = new KeyBinding();
            Configuration c = new Configuration(g, k);

            Player p = new Player("Red the moine");
            ModelInterface m = new GameModel();
            c.InitialiseModel(m);
            m.SetPlayer(p);

            Engine eng = new Engine(c, m);
            eng.run();
        }
         


    }
}
