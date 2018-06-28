using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fight_Club.Control;

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
            var formFightClub = new FormFightClub();
            IGameModel gameModel = new GameModel(textBoxName.Text);
            IControl controller = new Controller(formFightClub, gameModel);
            formFightClub.Show();
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
