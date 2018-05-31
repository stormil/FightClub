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
    partial class FormFightClub : Form
    {
        readonly GameModel game;

        public FormFightClub(GameModel game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void FormFightClub_Load(object sender, EventArgs e)
        {
            game.Player1.Wound += WoundLog;
            game.Player1.Wound += LoadPlayer1HealthPoints;
            game.Player2.Wound += WoundLog;
            game.Player2.Wound += LoadPlayer2HealthPoints;
            game.Player1.Death += DeathLog;
            game.Player2.Death += DeathLog;
            game.Player1.Death += LoadPlayer1HealthPoints;
            game.Player2.Death += LoadPlayer2HealthPoints;
            game.Player1.Block += BlockLog;
            game.Player2.Block += BlockLog;

            // game.Start += (sender, args) => StartGameLog();

            AssignNames();
            game.StartGame();
        }
        private void buttonBody_Click(object sender, EventArgs e)
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

        //private void buttonHeadPlayer1_Click(object sender, EventArgs e)
        //{
        //    if (roundIndex % 2 == 0)
        //    {
        //        player1.Blocked = BodyPart.Head;
        //        player1.GetHit(Bot.choseBodyPart());
        //    }
        //    else
        //    {
        //        player2.Blocked = Bot.choseBodyPart();
        //        player2.GetHit(BodyPart.Head);
        //    }
        //}

        //private void buttonTorsoPlayer1_Click(object sender, EventArgs e)
        //{
        //    if (roundIndex % 2 == 0)
        //    {
        //        player1.Blocked = BodyPart.Torso;
        //        player1.GetHit(Bot.choseBodyPart());
        //    }
        //    else
        //    {
        //        player2.Blocked = Bot.choseBodyPart();
        //        player2.GetHit(BodyPart.Torso);
        //    }
        //}

        //private void buttonLegsPlayer1_Click(object sender, EventArgs e)
        //{
        //    if (roundIndex % 2 == 0)
        //    {
        //        player1.Blocked = BodyPart.Legs;
        //        player1.GetHit(Bot.choseBodyPart());
        //    }
        //    else
        //    {
        //        player2.Blocked = Bot.choseBodyPart();
        //        player2.GetHit(BodyPart.Legs);
        //    }
        //}
        private void AssignNames()
        {
            labelPlayer1.Text = game.Player1.Name;
            labelPlayer2.Text = game.Player2.Name;
        }

        void StartGameLog(int roundIndex)
        {
            richTextBoxLog.AppendText("Start the Fight!\n");
            richTextBoxLog.AppendText(roundIndex % 2 == 0
                ? "First player attacks!\n"
                : "Second player attacks!\n");
        }

        void WoundLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.name + " is wounded!\n Next player attacks: ");
        }

        void LoadPlayer1HealthPoints(object sender, PlayerEventArgs e)
        {
            progressBarPlayer1.Value = e.healthPoints;
            labelHpPlayer1.Text = "HP:" + e.healthPoints;
        }
        void LoadPlayer2HealthPoints(object sender, PlayerEventArgs e)
        {
            progressBarPlayer2.Value = e.healthPoints;
            labelHpPlayer2.Text = "HP:" + e.healthPoints;
        }

        void DeathLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.name + " is dead!\n");
            buttonHead.Enabled = false;
            buttonTorso.Enabled = false;
            buttonLegs.Enabled = false;
        }

        void BlockLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.name + " blocked the punch!\n Next player attacks: ");
        }


        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLog.ScrollToCaret();
        }

        private void FormFightClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

// Make type of the player (bot or human)
// Make sizable style
// Create an tools for making 2+ players
// Move Log functions to new file
// Create nor opportunities (showing HP minus, starting new game)