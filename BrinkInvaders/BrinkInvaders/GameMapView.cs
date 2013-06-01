using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Linq;
using System.Text;
using BrickInvaders.View;
using BrickInvaders.Model;
namespace BrickInvaders
{
    namespace View
    {
        public class GameMapView : WorldView
        {
            public Form frame { get; set; }
            List<Element> elements;
            public GameMapView(Form frame)
            {
                this.frame = frame;

            }

            public override void Refresh(Observable o)
            {
                GameModel m = (GameModel)o;
                int max = m.GetBallCount();
                for (int i = 0; i < max; i++)
                {
                    Ball b = m.GetBall(i);
                    frame.Controls.Add(new CheckBox()
                    {
                        Location = new System.Drawing.Point((int)b.Position.X, (int)b.Position.Y),
                        Text = string.Empty
                    });
                }

                max = m.GetBrickCount();
                for (int i = 0; i < max; i++)
                {
                    BasicBrick b = m.GetBrick(i);
                    frame.Controls.Add(new TextBox()
                    {
                        Width = (int)b.Width,
                        Height = (int)b.Height,
                        BackColor = b.Color,

                        Location = new System.Drawing.Point((int)b.Position.X, (int)b.Position.Y),
                        Text = string.Empty
                    });

                   




                }


            }
        }
    }
}
