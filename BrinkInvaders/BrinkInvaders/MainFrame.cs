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
                this.button1.Dispose();
                if (this._e != null)
                {
                    this._e.start();
                }
                this.Focus();
            }

            public void Refresh(Observable m)
            {
                ModelInterface model = (ModelInterface)m;

                if (model.IsStopped())
                {
                    //GAMEOVER DESIGN
                    this.Controls.Clear();
                    InitializeComponent();
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
            }
        }
    }
}
