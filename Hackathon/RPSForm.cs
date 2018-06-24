using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon
{
    public partial class RPSForm : Form
    {
        public RPSForm()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            string[] rps = { "rock", "paper", "scissors" };
            int userPick;
            if (rockRadioButton.Checked)
                userPick = 0;
            else if (paperRadioButton.Checked)
                userPick = 1;
            else userPick = 2;

            int botPick = rnd.Next(3);

            if (userPick == botPick)
                outputLabel.Text = $"You both picked {rps[userPick]}, tie game.";
            else if (userPick == 0 && botPick == 1)
            {
                outputLabel.Text = $"You picked {rps[userPick]} and the bot picked {rps[botPick]}. The bot wins!";
                lossesNumericUpDown.Value += 1;
            }
            else if (userPick == 0 && botPick == 2)
            {
                outputLabel.Text = $"You picked {rps[userPick]} and the bot picked {rps[botPick]}. You win!";
                winsNumericUpDown.Value += 1;
            }
            else if (userPick == 1 && botPick == 0)
            {
                outputLabel.Text = $"You picked {rps[userPick]} and the bot picked {rps[botPick]}. You win!";
                winsNumericUpDown.Value += 1;
            }
            else if (userPick == 1 && botPick == 2)
            {
                outputLabel.Text = $"You picked {rps[userPick]} and the bot picked {rps[botPick]}. The bot wins!";
                lossesNumericUpDown.Value += 1;
            }
            else if (userPick == 2 && botPick == 0)
            {
                outputLabel.Text = $"You picked {rps[userPick]} and the bot picked {rps[botPick]}. The bot wins!";
                lossesNumericUpDown.Value += 1;
            }
            else if (userPick == 2 && botPick == 1)
            {
                outputLabel.Text = $"You picked {rps[userPick]} and the bot picked {rps[botPick]}. You win!";
                winsNumericUpDown.Value += 1;
            }
        }

    }
}
