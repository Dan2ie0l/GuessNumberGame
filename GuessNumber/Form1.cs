using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{

    public partial class Form1 : Form
    {
        public Random NumberGenerator = new Random();
        public int AINum = 0;
        public int NumOfPlayer = 50;
        public int attemptsCount = 10;
        public int min = 1;
        public int max = 100;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AINum = NumberGenerator.Next(1, 101);
            lblResult.Text = "";
            lblRes2.Text = "";
            lblWinGameOverIWin.Text = "";
           

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblAttemptsCount.Text = attemptsCount + " attempts" + " left";
            attemptsCount--;
            AINumberGuessing();

            PlayersNumberGuessing();

            lblRes2.Text = Convert.ToString(NumOfPlayer);

            if (attemptsCount <= 0)
            {
                lblAttemptsCount.Enabled = false;
                lblWinGameOverIWin.Text = Convert.ToString("Game Over!");
            }
        }




        private void btnTry_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        void AINumberGuessing()
        {
            int number = int.Parse(txtNumber.Text);
            if (number == AINum)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = Convert.ToString("You guessed it");

            }
            else if (number > AINum)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = Convert.ToString("Try again, it's greater");
            }
            else
            {
                lblResult.ForeColor = Color.Blue;
                lblResult.Text = Convert.ToString("Try again, it's less");
            }
        }

        void PlayersNumberGuessing()
        {
            if (rbEqual.Checked)
            {
                
                lblWinGameOverIWin.Text = "Game Over, I Won!!";
            }
            else if (rbGreater.Checked)
            {
                min = NumOfPlayer;
                NumOfPlayer = (min + max) / 2;
            }
            else if (rbLess.Checked)
            {
                max = NumOfPlayer;
                NumOfPlayer = (min + max) / 2;
            }
           

        }

    }
}
