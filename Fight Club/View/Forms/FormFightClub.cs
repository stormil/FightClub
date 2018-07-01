using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_Club
{
    partial class FormFightClub : Form, IView
    {

        IControl controller;
        public event EventHandler<IView> changed;

        public FormFightClub()
        {
            InitializeComponent();
        }

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

        #region Logs

        public void StartGameLog(object sender, GameModelEventArgs e)
        {
            richTextBoxLog.Clear();
            richTextBoxLog.AppendText("Start the Fight!\n");
            richTextBoxLog.AppendText(e.RoundIndex % 2 == 0
                ? "First player attacks!\n"
                : "Second player attacks!\n");
        }

        public void WoundLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.Name + " is wounded!\nNext player attacks... ");
        }

        public void LoadPlayerHealthPoints(object sender, PlayerEventArgs e)
        {
            switch (e.Id)
            {
                case 0:
                    progressBarPlayer1.Value = e.HealthPoints;
                    labelHpPlayer1.Text = "HP:" + e.HealthPoints;
                    break;
                case 1:
                    progressBarPlayer2.Value = e.HealthPoints;
                    labelHpPlayer2.Text = "HP:" + e.HealthPoints;
                    break;
                default:
                    break;
            }
        }

        public void DeathLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.Name + " is dead!\n");
            buttonHead.Enabled = false;
            buttonTorso.Enabled = false;
            buttonLegs.Enabled = false;
        }

        public void BlockLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.Name + " blocked the punch!\nNext player attacks... ");
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLog.ScrollToCaret();
        }

        #endregion

        private void FormFightClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void SetController(IControl controller)
        {
            this.controller = controller;
        }
    }
}