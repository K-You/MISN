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


        public class ElementView : PictureBox, Observer
        {
            public Form form { get; set; }

            public ElementView()
            {
            }

            public ElementView(Form f)
                : base()
            {
                if (f != null)
                {
                    this.form = f;
                    f.Controls.Add(this);
                }
            }

            public virtual void Refresh(Observable o)
            {
                Vector2D dim = ((MainFrame)form).GridDimensions;
                Vector2D padding = new Vector2D(form.ClientSize.Width / dim.X, form.ClientSize.Height / dim.Y);

                Element e = (Element)o;
                this.Width = (int)(e.Width * padding.X);
                this.Height = (int)(e.Height * padding.Y);
                this.Location = new System.Drawing.Point((int)(e.Position.X * padding.X), (int)((dim.Y - e.Position.Y - 1) * padding.Y));
                this.BackColor = e.Color;
            }
        }
    }
}
