using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int win = 0;
        int loss = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            DisplayDecision(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            DisplayDecision(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            DisplayDecision(3);
        }
       private void DisplayDecision(int userGuess)
        {
            string result = null;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);
            
            if (userGuess == 1)
            {
                if (1 == randomNumber)
                {
                    result = "Tie";
                }
                else if (randomNumber == 2)
                {
                    result = "You Lose";
                    loss++;
                }
                else if (randomNumber == 3)
                {
                    result = "You Win";
                    win++;
                }

            }
            if (userGuess == 2)
            {
                if (1 == randomNumber)
                {
                    result = "You win";
                    win++;
                }
                else if (randomNumber == 2)
                {
                    result = "Tie";
                }
                else if (randomNumber == 3)
                {
                    result = "You Lose";
                    loss++;
                }

            }
            if (userGuess == 3)
            {
                if (1 == randomNumber)
                {
                    result = "You Lose";
                    loss++;
                }
                else if (randomNumber == 2)
                {
                    result = "You Win";
                    win++;
                }
                else if (randomNumber == 3)
                {
                    result = "Tie";
                }

            }
            lblResult.Text = result;
            lblWin.Text = win.ToString();
            lblLoss.Text = loss.ToString();
        }
    }
}
