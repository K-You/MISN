using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BrickInvaders.Controller;

namespace BrickInvaders
{
    namespace View
    {
        public partial class MainFrame : Form
        {
            private Engine _e;

            public MainFrame(Engine e)
            {
                InitializeComponent();
                this._e = e;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.button1.Dispose();
                this._e.start();
            }
        }
    }
}
