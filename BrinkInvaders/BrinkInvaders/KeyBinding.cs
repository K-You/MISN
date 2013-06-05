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
            private Hashtable _keys;

            public KeyBinding()
            {
                _keys = new Hashtable();
                //A ajouter ici la liste des touches dont on aura besoin, stockées en dur dans un premier temps, xml ensuite?
                _keys["left"] = 37;
                _keys["right"] = 39;
                _keys["esc"] = 27;
            }

            public int GetKey(String functionnality)
            {
                return (int)_keys[functionnality];
            }
        }
    }
}