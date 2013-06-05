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
            private static Vector2D dim, padding;
            private bool _dimensioned = false; // were dimension set?
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
                    dim = ((MainFrame)form).GridDimensions;
                    padding = new Vector2D(form.ClientSize.Width / dim.X, form.ClientSize.Height / dim.Y);
                    this.Location = new System.Drawing.Point(int.MinValue, int.MinValue);
                   f.Controls.Add(this);
                }
            }

            public virtual void Refresh(Observable o)
            {
                Element e = (Element)o;

                if (!_dimensioned)
                {
                    this.Width = (int)(e.Width * padding.X);
                    this.Height = (int)(e.Height * padding.Y);
                    _dimensioned = true;
                }

                if (e.Position.Y < dim.Y)
                {
                    this.Location = new System.Drawing.Point((int)(e.Position.X * padding.X), (int)((dim.Y - e.Position.Y - 1) * padding.Y));
                }
              
            }
        }
    }
}
