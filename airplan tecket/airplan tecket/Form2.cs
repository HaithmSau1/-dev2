using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airplan_tecket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // nesne çağırdık.

            
            label4.Text = Form1.firstName + "  "+  Form1.LastName;
            label3.Text = Form1.From;
            label6.Text = Form1.To;
            label3.Text = Form1.From;
            label12.Text = Form1.StartTripDate + " to " + Form1.EndTripDate;
            label13.Text = Form1.DocumentNo;
            label14.Text = Form1.ExpiryDate;
            label15.Text = Form1.WeightBaggage;



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // program kapatmak icin
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
