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

            public void Refresh(Observable m)
            {
                ModelInterface model = (ModelInterface)m;

                if (model.IsStopped() && model.IsLost())
                {
                    this.Controls.Clear();

                    List<Score> scores = model.GetScores();
                    int i = 0;

                    Label title = new System.Windows.Forms.Label();
                    this.SuspendLayout();
                    // 
                    // title
                    // 
                    title.AutoSize = true;
                    title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
                    title.Location = new System.Drawing.Point(90, 38);
                    title.Name = "title";
                    title.Size = new System.Drawing.Size(200, 41);
                    title.TabIndex = 0;
                    title.Text = "High scores";
                    this.Controls.Add(title);

                    foreach (Score sc in scores)
                    {
                        Control label = new Label();
                        label.Text = i + 1 + " :";
                        label.BackColor = Color.Black;
                        label.ForeColor = Color.White;
                        label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label.Size = new System.Drawing.Size(30, 30);
                        label.Location = new System.Drawing.Point(60, i * 60 + 120);
                        this.Controls.Add(label);

                        Control name = new Label();
                        name.BackColor = Color.Black;
                        name.ForeColor = Color.White;
                        name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        name.Size = new System.Drawing.Size(80, 30);
                        name.Location = new System.Drawing.Point(120, i * 60 + 120);
                        this.Controls.Add(name);
                        name.Text = sc.Player.Pseudo;

                        Control score = new Label();
                        score.Text = sc.Value.ToString();
                        score.BackColor = Color.Black;
                        score.ForeColor = Color.White;
                        score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        score.Size = new System.Drawing.Size(50, 30);
                        score.Location = new System.Drawing.Point(210, i * 60 + 120);
                        this.Controls.Add(score);

                        i++;
                    }
                }
                else if (model.IsStopped())
                {
                    this.Controls.Clear();
                }
                else if (model.IsEnded())
                {
                    this.Close();
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
                    this._e.Start();
                }
                this.Focus();
            }
        }
    }
}