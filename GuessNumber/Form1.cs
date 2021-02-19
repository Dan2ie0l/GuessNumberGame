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
        public int rememberedNum = 0;
        public int rememberedNumOfPlayer = 0;
        public int attemptsCount = 10;
        public int i = 1;
        public int j = 100;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rememberedNum = NumberGenerator.Next(1, 101);
            lblResult.Text = "";
            lblRes2.Text = "";
            lblWinGameOverIWin.Text = "";
            lblAttemptsCount.Text = attemptsCount + " attempts" + " left";

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            int number = int.Parse(txtNumber.Text);
            if (number == rememberedNum)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = Convert.ToString("You guessed it");

            }
            else if (number > rememberedNum)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = Convert.ToString("Try again, it's greater");
            }
            else
            {
                lblResult.ForeColor = Color.Blue;
                lblResult.Text = Convert.ToString("Try again, it's less");
            }
            if (rbEqual.Checked)
            {
                lblRes2.Text = "I Win!";
                lblWinGameOverIWin.Text = "Game Over";
            }
            



        }




        private void btnTry_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }




    }
}
