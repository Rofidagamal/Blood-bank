using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boodbank2
{
    public partial class Fpatient_ins : Form
    {
        public Fpatient_ins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (blood_type.Text == "" || pssn.Text == "" || address.Text == "" || phone.Text == "" || lname.Text == "" || fname.Text == "" || hospital_name.Text == "" || weight.Text == "")
            {
                MessageBox.Show("You must compelte all texts");

            }
            else
            {
                Cpatient.insert(pssn.Text, blood_type.Text, weight.Text, hospital_name.Text, fname.Text, lname.Text, phone.Text, address.Text);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fpatient f = new Fpatient();
            f.Show();
            this.Hide();
        }
    }
}
