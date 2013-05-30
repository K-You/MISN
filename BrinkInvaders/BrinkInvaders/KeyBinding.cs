using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BrickInvaders
{

    namespace Controller
    {

        public class KeyBinding
        {
            private Hashtable keys;


            public KeyBinding()
            {
                keys = new Hashtable();
                //A ajouter ici la liste des touches dont on aura besoin, stockées en dur dans un premier temps, xml ensuite?
                keys["up"] = 38;
                keys["down"] = 40;
                keys["left"] = 37;
                keys["right"] = 39;
            }
            public int GetKey(String functionnality)
            {
                return (int)keys[functionnality];
            }
        }
    }
}