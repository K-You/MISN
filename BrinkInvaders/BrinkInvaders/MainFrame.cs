using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BrickInvaders.Model;
using BrickInvaders.Controller;

namespace BrickInvaders
{
    namespace View
    {
        public partial class MainFrame : Form, Observer
        {
            private Engine _e;
            private Vector2D _grid = new Vector2D();

            public MainFrame()
            {
                InitializeComponent();
                this.KeyPreview = true;
            }

            public Engine Engine
            {
                set { this._e = value; }
            }

            private void button1_Click(object sender, EventArgs e)
            {
            }

            public void Refresh(Observable m)
            {
                ModelInterface model = (ModelInterface)m;

                if (model.IsStopped())
                {
                    this.Controls.Clear();


                    List<Score> scores = model.GetScores();
                    int i = 0;
                    foreach(Score sc in scores)
                    {
                        Control label = new Label() ;
                            label.Text = i + 1 + " :";
                            label.BackColor = Color.Black;
                            label.ForeColor = Color.White;
                            label.Location = new System.Drawing.Point(30, i*10 + 20);
                            this.Controls.Add(label);

                            Control name = new Label() { Width = 40 , Height=20 };
                            name.Text = sc.Player.Pseudo;
                            name.BackColor = Color.Yellow;
                            name.ForeColor = Color.White;
                            name.Location = new System.Drawing.Point(70, i * 10 + 20);
                            this.Controls.Add(name);

                            Control score = new Label();
                            score.Text = sc.Value.ToString();
                            score.BackColor = Color.Black;
                            score.ForeColor = Color.White;
                            score.Location = new System.Drawing.Point(110, i * 10 + 20);
                            this.Controls.Add(score);
                       
                        i++;
                    }



                }

                this._grid = model.GetMapDimensions();
            }

            public Vector2D GridDimensions
            {
                get { return _grid; }
            }

            private void MainFrame_KeyDown(object sender, KeyEventArgs e)
            {
                _e.CaptureKey(sender, e);
            }

            private void MainFrame_Load(object sender, EventArgs e)
            {
                
                if (this._e != null)
                {
                    this._e.start();
                }
                this.Focus();
            }

            private void button2_Click(object sender, EventArgs e)
            {
            }
        }
    }
}
