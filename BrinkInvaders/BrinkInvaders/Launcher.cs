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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private string pseudo;
        private string modeName;    // faire une enum
        private string shipName;    // faire une enum


        private void button1_Click(object sender, EventArgs e)
        {
            this.pseudo = pseudoBox.Text;
            this.modeName = modeBox.Text;
            this.shipName = shipBox.Text;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            new Configuration(new BasicMode(), new Ship(this.shipName)); // à modifier new Mode
        }

        
    }
}
