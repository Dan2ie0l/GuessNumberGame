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
        static Random rnd = new Random();
        static int mtapahac = rnd.Next(1, 100);
        static int mtapahac2 = 0;
        int i = 0;
        int j = 100;


        public Form1()
        {
            InitializeComponent();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            int number = int.Parse(txtNumber.Text);
            if (number == mtapahac)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = Convert.ToString("Gushakecir");
            }
            else if (number > mtapahac)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = Convert.ToString("Porcir krkin, mec e");
            }
            else
            {
                lblResult.ForeColor = Color.BlueViolet;
                lblResult.Text = Convert.ToString("Porcir krkin, poqr e");
            }

            lblRes2.Text = Convert.ToString(mtapahac2);

        }

        private void btnHavasar_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Green;
            lblEnd.Text = Convert.ToString("You Win!");

        }

        private void btnMec_Click(object sender, EventArgs e)
        {

            int i = this.i;
            int j = this.j;


            int mid = (i + j) / 2;
            this.j = mid;

            mtapahac2 = mid;
           // lblRes2.Text = Convert.ToString(mtapahac2);

        }

        private void btnPoqr_Click(object sender, EventArgs e)
        {
            int i = this.i;
            int j = this.j;

            int mid = (i + j) / 2;
            this.i = mid;
            

            mtapahac2 = mid;
           // lblRes2.Text = Convert.ToString(mtapahac2);
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Convert.ToString(" ");
            lblRes2.Text = Convert.ToString(" ");
            lblEnd.Text = Convert.ToString(" ");
            lblResult.Text = Convert.ToString(" ");
            this.i = 0;
            this.j = 100;
        }
    }
}
