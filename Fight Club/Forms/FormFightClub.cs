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
    partial class FormFightClub : Form, IControl, IView
    {
        readonly IGameModel game;

        public FormFightClub(IGameModel game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void FormFightClub_Load(object sender, EventArgs e)
        {
            // adding subscribers to player and game events
            game.Player1.Wound += WoundLog;
            game.Player1.Wound += LoadPlayer1HealthPoints;
            game.Player2.Wound += WoundLog;
            game.Player2.Wound += LoadPlayer2HealthPoints;
            game.Player1.Death += DeathLog;
            game.Player2.Death += DeathLog;
            game.Player1.Death += LoadPlayer1HealthPoints;
            game.Player2.Death += LoadPlayer2HealthPoints;
            game.Player1.Death += RequestNewGameStart;
            game.Player2.Death += RequestNewGameStart;
            game.Player1.Block += BlockLog;
            game.Player2.Block += BlockLog;

            game.Start += StartGameLog;

            AssignNamesToLabels();
            game.StartGame();
        }

        #region Controller

        public void ButtonBody_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == buttonHead)
            {
                game.NextStep(BodyPart.Head);
            }
            else if (button == buttonTorso)
            {
                game.NextStep(BodyPart.Torso);
            }
            else if (button == buttonLegs)
            {
                game.NextStep(BodyPart.Legs);
            }
        }

        #endregion

        private void AssignNamesToLabels()
        {
            labelPlayer1.Text = game.Player1.Name;
            labelPlayer2.Text = game.Player2.Name;
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
                game.StartGame();
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

        public void LoadPlayer1HealthPoints(object sender, PlayerEventArgs e)
        {
            progressBarPlayer1.Value = e.HealthPoints;
            labelHpPlayer1.Text = "HP:" + e.HealthPoints;
        }
        public void LoadPlayer2HealthPoints(object sender, PlayerEventArgs e)
        {
            progressBarPlayer2.Value = e.HealthPoints;
            labelHpPlayer2.Text = "HP:" + e.HealthPoints;
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
    }
}