using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Linq;
using System.Text;
using BrickInvaders.View;
using BrickInvaders.Model;
using System.Drawing;
namespace BrickInvaders
{
    namespace View
    {
        public class GameMapView : WorldView
        {
            public ContainerControl frame { get; set; }
            List<Element> elements;
            public GameMapView(ContainerControl frame)
            {
                this.frame = frame;
                Button b = new Button();
                b.Click += new System.EventHandler(test);
                frame.Controls.Add(b);
               
            }



            public void test(object sender, EventArgs e)
            {
                TextBox t = new TextBox();
                t.Width = 500;
                this.frame.Controls.Add(t);
                t.Width = 200;
            }
            public override void Refresh(Observable o)
            {
                Console.Write("Refreshing GameMapView");

                GameModel m = (GameModel)o;

            
                int max = m.GetBallCount();
                for (int i = 0; i < max; i++)
                {
                    Vector2D position = m.GetBallPosition(i);
                    frame.Controls.Add(new CheckBox()
                    {
                        Location = new System.Drawing.Point((int)position.X, (int)position.Y),
                        Text = string.Empty
                    });
                }

                max = m.GetBrickCount();
                for (int i = 0; i < max; i++)
                {
                    Color c = m.GetBrickColor(i);
                    Vector2D dimension = m.GetBrickDimensions(i);
                    Vector2D position = m.GetBrickPosition(i);
                    frame.Controls.Add(new TextBox()
                    {
                        Width = (int)dimension.X,
                        Height = (int)dimension.Y,
                        BackColor = c,

                        Location = new System.Drawing.Point((int)position.X, (int)position.Y),
                        Text = string.Empty
                    });
                }
            }
        }
    }
}
