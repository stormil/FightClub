using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_Club
{
    partial class FormPlayer : Form, IViewPlayer
    {
        IControl controller;

        public FormPlayer(int id)
        {
            InitializeComponent();
            labelPlayer1.Text = "Player " + (id+1);
            this.Text = "Player " + (id+1);
            var height = (Screen.PrimaryScreen.Bounds.Height / 2) - 350;
            switch (id)
            {
                case 0:
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 400, height);
                    break;
                case 1:
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 30, height);
                    SwitchControls(this, new GameModelEventArgs(0));
                    break;
                default:
                    break;
            }
        }

        private void ButtonBody_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            BodyPart chosenBodyPart;
            if (button == buttonHead)
            {
                chosenBodyPart = BodyPart.Head;
            }
            else if (button == buttonTorso)
            {
                chosenBodyPart = BodyPart.Torso;
            }
            else 
            {
                chosenBodyPart = BodyPart.Legs;
            }
            controller.GetBodyPart(chosenBodyPart);
        }

        public void RequestNewGameStart(object sender, PlayerEventArgs e)
        {
            var result1 = MessageBox.Show("Do you want to start a new game?",
                "New Game",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                ResetButtons();
                controller.StartNewGame();
            }
        }

        private void ResetButtons()
        {
            buttonHead.Enabled = true;
            buttonTorso.Enabled = true;
            buttonLegs.Enabled = true;
        }

        public void LoadPlayerHealthPoints(object sender, PlayerEventArgs e)
        {
            progressBarPlayer1.Value = e.HealthPoints;
            labelHpPlayer1.Text = "HP:" + e.HealthPoints;
        }

        public void SwitchControls(object sender, GameModelEventArgs e)
        {
            buttonHead.Enabled = buttonHead.Enabled != true;
            buttonTorso.Enabled = buttonTorso.Enabled != true;
            buttonLegs.Enabled = buttonLegs.Enabled != true;
        }

        public void SetController(IControl controller)
        {
            this.controller = controller;
        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
