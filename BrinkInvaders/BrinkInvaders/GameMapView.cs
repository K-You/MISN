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

            public GameMapView(ContainerControl frame)
            {
                this.frame = frame;
            }

            public override void Refresh(Observable o)
            {
                GameModel m = (GameModel)o;
                Size client = this.frame.ClientSize;
                Vector2D size = m.GetMapDimensions();

                Vector2D gridpadding = new Vector2D(client.Width / size.X, client.Height / size.Y);
                Vector2D dimension, position;
                Color c;

                int max = m.GetBallCount();
                for (int i = 0; i < max; i++)
                {
                    position = m.GetBallPosition(i);
                    frame.Controls.Add(new CheckBox()
                    {
                        Location = new System.Drawing.Point((int)(position.X * gridpadding.X), (int)((size.Y - position.Y - 1) * gridpadding.Y)),
                        Text = string.Empty
                    });
                }

                max = m.GetBrickCount();
                for (int i = 0; i < max; i++)
                {
                    c = m.GetBrickColor(i);
                    dimension = m.GetBrickDimensions(i);
                    position = m.GetBrickPosition(i);
                    frame.Controls.Add(new TextBox()
                    {
                        Width = (int)(dimension.X * gridpadding.X),
                        Height = (int)(dimension.Y * gridpadding.Y),
                        BackColor = c,

                        Location = new System.Drawing.Point((int)(position.X * gridpadding.X), (int)((size.Y - position.Y - 1) * gridpadding.Y)),
                        Text = string.Empty
                    });
                }

                dimension = m.GetShipDimensions();
                position = m.GetShipPosition();
                c = m.GetShipColor();
                frame.Controls.Add(new TextBox()
                {
                    Width = (int)(dimension.X * gridpadding.X),
                    Height = (int)(dimension.Y * gridpadding.Y),
                    BackColor = c,

                    Location = new System.Drawing.Point((int)(position.X * gridpadding.X), (int)((size.Y - position.Y - 1) * gridpadding.Y)),
                    Text = string.Empty
                });
            }
        }
    }
}
