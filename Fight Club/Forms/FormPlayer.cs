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
        public FormPlayer(int id)
        {
            InitializeComponent();
            labelPlayer1.Text = "Player " + id;
        }

        IControl controller;
        public event EventHandler<IView> changed;

        public void ButtonBody_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == buttonHead)
            {
                controller.GetBodyPart(BodyPart.Head);
            }
            else if (button == buttonTorso)
            {
                controller.GetBodyPart(BodyPart.Torso);
            }
            else if (button == buttonLegs)
            {
                controller.GetBodyPart(BodyPart.Legs);
            }
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

        private void SwitchControls()
        {
            buttonHead.Enabled = buttonHead.Enabled != true;
            buttonTorso.Enabled = buttonTorso.Enabled != true;
            buttonLegs.Enabled = buttonLegs.Enabled != true;
        }

        private void NextRound()
        {

        }

        public void SetController(IControl controller)
        {
            this.controller = controller;
        }
    }
}
