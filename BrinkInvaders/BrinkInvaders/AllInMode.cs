using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        public class AllInMode : GameMode
        {
            // Tout monde hérite du GameMode
            // Le AllInMode utilise le générateur standart et la vitesse n'augmente pas au fur et à mesure du niveau.
            // En revanche le nombre de briques augmentent dans le Générateur fonction du niveau.
            public AllInMode()
                : base(new BasicMapGenerator(), "AllIn mode", new Vector2D(0, -0.005), new Vector2D(0, 0))
            {

            }
        }

    }
}
