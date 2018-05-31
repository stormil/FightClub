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
            if ((textBoxName.Text != "") && (textBoxName.Text != " "))
            {
                var gameModel = new GameModel(textBoxName.Text);
                var formFightClub = new FormFightClub(gameModel);
                formFightClub.Show();
                this.Hide();
            }
        }
    }
}
