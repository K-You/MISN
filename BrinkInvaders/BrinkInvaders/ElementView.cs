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
            private static Vector2D _dim, _padding;
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
                    _dim = ((MainFrame)form).GridDimensions;
                    _padding = new Vector2D(form.ClientSize.Width / _dim.X, form.ClientSize.Height / _dim.Y);
                    this.Location = new System.Drawing.Point(int.MinValue, int.MinValue);
                   f.Controls.Add(this);// on affiche l'element dans la frame
                }
            }

            public virtual void Refresh(Observable o)
            {
                Element e = (Element)o;

                if (!_dimensioned)
                {
                    this.Width = (int)(e.Width * _padding.X);
                    this.Height = (int)(e.Height * _padding.Y);
                    _dimensioned = true;
                }

                if (e.Position.Y < _dim.Y)  //refraichissement des éléments dans la fenetre uniquement
                {
                    this.Location = new System.Drawing.Point((int)(e.Position.X * _padding.X), (int)((_dim.Y - e.Position.Y - 1) * _padding.Y));
                }
              
            }
        }
    }
}
