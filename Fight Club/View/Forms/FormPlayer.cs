using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.Text = "Player " + (id + 1);
            string path = Environment.CurrentDirectory;
            string directory = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            var height = (Screen.PrimaryScreen.Bounds.Height / 2) - 350;
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            switch (id)
            {
                case 0:
                    labelPlayer1.Text = "You";
                    pictureBoxPlayer.Image = Image.FromFile(directory + "\\Resources\\Narrator.png");
                    labelInstruction.Text = "Set block on:";
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 400, height);
                    SwitchControls(this, new EventArgs());
                    break;
                case 1:
                    labelPlayer1.Text = "Enemy";
                    pictureBoxPlayer.Image = Image.FromFile(directory + "\\Resources\\Tyler.png");
                    labelInstruction.Text = "Attack his:";
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 30, height);
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
                controller.StartNewGame();
            }
            else
            {
                this.Close();
            }
        }

        public void LoadPlayerHealthPoints(object sender, PlayerEventArgs e)
        {
            progressBarPlayer1.Value = e.HealthPoints;
            labelHpPlayer1.Text = "HP:" + e.HealthPoints;
        }

        public void SwitchControls(object sender, EventArgs e)
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
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
            else
            {
            }
        }
    }
}
