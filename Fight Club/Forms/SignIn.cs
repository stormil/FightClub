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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void buttonStartFight_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text == "") || (textBoxName.Text == " ")) return;
            //var formFightClub = new FormFightClub();
            var formLog = new Log();
            var formPlayer1 = new FormPlayer(0);
            var formPlayer2 = new FormPlayer(1);
            IGameModel gameModel = new GameModel(textBoxName.Text);
            IControl controller = new Controller(formPlayer1,formPlayer2, formLog, gameModel);
            formPlayer1.Show();
            formPlayer2.Show();
            formLog.Show();
            Hide();
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonStartFight.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
