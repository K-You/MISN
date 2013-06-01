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


        public  class ElementView : PictureBox, Observer
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
                this.Width = (int)e.Width;
                this.Height = (int)e.Height;
                this.Location = new System.Drawing.Point((int)e.Position.X, (int)e.Position.Y);
            }

        }
    }

}
