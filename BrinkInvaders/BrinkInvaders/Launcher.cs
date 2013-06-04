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
        public partial class Launcher : Form
        {
            public Launcher()
            {
                InitializeComponent();
            }

            private string pseudo;
            private enum modeEnum { AllIn, HighSpeed };
            private GameMode[] modeArray = new GameMode[] { new AllInMode(), new HighSpeedMode() };
            private enum shipEnum { Ship1, Ship2, Ship3 };
            private Ship[] shipArray = new Ship[] { new Ship(""), new Ship(""), new Ship("") };
            private Configuration configuration = null;

            private void button1_Click(object sender, EventArgs e)
            {
                if ((pseudoBox.Text != string.Empty) && (modeBox.Text != string.Empty) && (shipBox.Text != string.Empty))
                {
                    this.pseudo = pseudoBox.Text;
                    GameMode mode = modeArray[(int)Enum.Parse(typeof(modeEnum), this.modeBox.Text)];
                    Ship ship = shipArray[(int)Enum.Parse(typeof(shipEnum), this.shipBox.Text)]; //TODO use ship
                    this.configuration = new Configuration(mode, new KeyBinding()); //TODO apply keybinding
                    this.Close();
                }
            }

            public Configuration Configuration
            {
                get { return configuration; }
            }

            public string Pseudo
            {
                get { return pseudo; }
            }

            private void Launcher_Load(object sender, EventArgs e)
            {
                foreach (string mode in Enum.GetNames(typeof(modeEnum)))
                {
                    this.modeBox.Items.Add(mode);
                    this.pseudoBox.Text = "Pseudo";
                  //  this.modeBox.SelectedItem = "test";
                  //  this.shipBox.SelectedItem = "test";
                    
                }

                foreach (string ship in Enum.GetNames(typeof(shipEnum)))
                {
                    this.shipBox.Items.Add(ship);
                }
            }
        }
    }
}
