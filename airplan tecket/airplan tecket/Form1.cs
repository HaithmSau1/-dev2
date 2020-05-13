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
    public partial class Form1 : Form
    {
        public static Boolean Passport, IDCard;
        public static string To, From, StartTripDate, EndTripDate, firstName, LastName, DocumentNo, IssuDate, ExpiryDate, WeightBaggage; // yeni viribal

        private void Vtnbook_Click(object sender, EventArgs e)
        {
            To = textBox1.Text; // to box
            From = textBox2.Text; // from box
            StartTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            EndTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");

            firstName = textBox3.Text; // first name
            LastName = txtlastname.Text; // last name
            DocumentNo = txtDocumentnamber.Text;
            IssuDate = dateTimePicker1.Value.ToString("dd MMM yyyy"); // igssu data time 
            ExpiryDate = dateTimePicker2.Value.ToString("dd MMM yyyy"); // expiry data time
            WeightBaggage = numericUpDown1.Value.ToString();

            this.Hide();
                Form2 h = new Form2();  // ikince form bagilamak icin
                   h.Show(); // ikinci form cikacak
                 
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;

            numericUpDown1.Increment = 5; // 5 artiriyor ve kullanci rakem yazmaz
            numericUpDown1.ReadOnly = true;
        }

        private void RpdidCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rpdidCard.Checked) //id card kontor etmek
            {
                lblDocNo.Text = "ID Card No:";
                Dataissue.Text = "ID Card Issue Data:";
                dateexpiry.Text = "ID Card Expiry No:";

                IDCard = true;


            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt; // expirt time will be +1
        }

        private void RdpPassport_CheckedChanged(object sender, EventArgs e)
        {

            if (rdpPassport.Checked) // passport kontrol etmek;
            {
                lblDocNo.Text = "Passport No:";
                Dataissue.Text = "Passport Issue Data:";
                dateexpiry.Text = "Passport Expiry No:";

                Passport = true;


            }
        }
    }
}
