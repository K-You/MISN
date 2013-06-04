﻿using System;
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
            private Vector2D _grid = new Vector2D(1,1);

            public MainFrame()
            {
                InitializeComponent();
            }

            public Engine Engine
            {
                set { this._e = value; }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.button1.Dispose();
                if (this._e != null)
                    this._e.start();
            }

            public void Refresh(Observable m)
            {
                this._grid = ((ModelInterface)m).GetMapDimensions();
            }

            public Vector2D GridDimensions
            {
                get { return _grid; }
            }
        }
    }
}
