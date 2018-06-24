using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Hackathon
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void RPSButton_Click(object sender, EventArgs e)
        {
            RPSForm rps = new RPSForm();
            rps.Show();
        }

        private void scrambleButton_Click(object sender, EventArgs e)
        {
            WordScrambler word = new WordScrambler();
            word.Show();
        }

        private void invaderButton_Click(object sender, EventArgs e)
        {
            SpaceInvaders space = new SpaceInvaders();
            space.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form2 form = new WindowsFormsApp1.Form2();
            form.Show();
        }
    }
}
