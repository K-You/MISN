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
            }

            public override void Refresh(Observable o)
            {
                Console.Write("Refreshing GameMapView");

                GameModel m = (GameModel)o;
                Size client= this.frame.ClientSize;
                Vector2D size = m.GetMapDimensions();

                Vector2D gridpadding = new Vector2D(client.Width/size.X,client.Height/size.Y);

                int max = m.GetBallCount();
                for (int i = 0; i < max; i++)
                {
                    Vector2D position = m.GetBallPosition(i);
                    frame.Controls.Add(new CheckBox()
                    {
                        Location = new System.Drawing.Point((int)(position.X*gridpadding.X), (int)(position.Y*gridpadding.Y)),
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
                        Width = (int)(dimension.X * gridpadding.X),
                        Height = (int)(dimension.Y * gridpadding.Y),
                        BackColor = c,

                        Location = new System.Drawing.Point((int)(position.X * gridpadding.X), (int)(position.Y * gridpadding.Y)),
                        Text = string.Empty
                    });
                }

                //DRAW SHIP
            }
        }
    }
}
