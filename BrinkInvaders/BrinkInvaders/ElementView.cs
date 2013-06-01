using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using BrickInvaders.Model;
using BrickInvaders.View;
namespace BrickInvaders
{
    namespace View
    {


        public abstract class ElementView : Control,Observer
        {
            public WorldView worldWiew { get; set; }

            public ElementView()
            {

            }

            public ElementView(WorldView W):base()
            {
               
                this.worldWiew = W;
            }
            public virtual void Refresh(Observable o)
            {
                Element e = (Element)o;
                
            
            }

        }
    }

}
