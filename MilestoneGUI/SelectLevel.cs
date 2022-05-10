using System;
using System.Drawing;
using System.Windows.Forms;

namespace MilestoneGUI
{
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        private void btn_play_MouseEnter(object sender, EventArgs e)
        {
            if (rb_easy.Checked)
            {
                btn_play.BackColor = Color.Green;
            }

            if (rb_medium.Checked)
            {
                btn_play.BackColor = Color.Orange;
            }

            if (rb_hard.Checked)
            {
                btn_play.BackColor = Color.Red;
            }
        }

        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            btn_play.BackColor = Color.White;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (rb_easy.Checked)
            {
                Game game = new Game("Easy");
                game.Show();
            }

            if (rb_medium.Checked)
            {
                Game game = new Game("Medium");
                game.Show();
            }

            if (rb_hard.Checked)
            {
                Game game = new Game("Hard");
                game.Show();
            }

            this.Hide();
        }
    }
}