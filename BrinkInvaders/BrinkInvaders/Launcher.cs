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
        public partial class Launcher : Form
        {
            public Launcher()
            {
                InitializeComponent();
            }

            private string pseudo;
            private enum modeEnum { AllIn, HighSpeed };
            private GameMode[] modeArray = new GameMode[] { new AllInMode(), new HighSpeedMode() };
            private enum shipEnum { Longboard, Starship, Firefly };
            private ShipArguments[] shipArray = new ShipArguments[] { new ShipArguments("Longboard", Ship.DEFAULT_POSITION, new Vector2D(0.25,0), new Vector2D(3,1), int.MaxValue, 4, Color.Blue), 
                                                    new ShipArguments("Starship", Ship.DEFAULT_POSITION, new Vector2D(0.5,0), new Vector2D(2,1), int.MaxValue, 3, Color.Green), 
                                                    new ShipArguments("Firefly", Ship.DEFAULT_POSITION, new Vector2D(1,0), new Vector2D(1,1), int.MaxValue, 2, Color.Red) };
            private Configuration configuration = null;

            private void button1_Click(object sender, EventArgs e)
            {
                if ((pseudoBox.Text != string.Empty) && (modeBox.Text != string.Empty) && (shipBox.Text != string.Empty))
                {
                    this.pseudo = pseudoBox.Text;
                    GameMode mode = modeArray[(int)Enum.Parse(typeof(modeEnum), this.modeBox.Text)];
                    ShipArguments ship = shipArray[(int)Enum.Parse(typeof(shipEnum), this.shipBox.Text)];
                    this.configuration = new Configuration(mode, ship, new KeyBinding());
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
                }

                foreach (string ship in Enum.GetNames(typeof(shipEnum)))
                {
                    this.shipBox.Items.Add(ship);
                }

                // default values
                this.pseudoBox.Text = "Pseudo";
                this.modeBox.SelectedIndex = 0;
                this.shipBox.SelectedIndex = 0;
            }

   
        }
    }
}
