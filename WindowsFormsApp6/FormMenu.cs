using System;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра: Космический стрелок\nУправление:\n← → — движение\nПробел — выстрел", "О игре");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGame gameForm = new FormGame();
            gameForm.FormClosed += (s, args) => this.Show();
            gameForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
