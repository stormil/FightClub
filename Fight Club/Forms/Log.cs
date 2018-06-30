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
    partial class Log : Form, IViewLog
    {
        IControl controller;

        public Log()
        {
            InitializeComponent();
        }

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

        public void DeathLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.Name + " is dead!\n");
        }

        public void BlockLog(object sender, PlayerEventArgs e)
        {
            richTextBoxLog.AppendText(e.Name + " blocked the punch!\nNext player attacks... ");
        }

        public void SetController(IControl controller)
        {
            this.controller = controller;
        }
    }
}
