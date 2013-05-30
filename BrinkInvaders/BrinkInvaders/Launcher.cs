using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrickInvaders
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private string pseudo;
        private string modeName;
        private string shipName;


        private void button1_Click(object sender, EventArgs e)
        {
            this.pseudo = pseudoBox.Text;
            this.modeName = modeBox.Text;
            this.shipName = shipBox.Text;
        }
    }
}
