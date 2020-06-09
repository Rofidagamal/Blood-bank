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
    public partial class FBloodBag_ins : Form
    {
        String type="";
        public FBloodBag_ins()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bcode.Text == "" || cost.Text == "" ||type== "" || bb_name.Text == "" || assn.Text == "" || don_type.Text == "" || don_amount.Text == "" )
            {
                MessageBox.Show("You must compelte all texts");
            }
            else
            {
                CBloodBag.insert(bcode.Text, cost.Text, type, bb_name.Text, assn.Text, don_type.Text, don_amount.Text);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FBloodBag f = new FBloodBag();
            f.Show();
            this.Hide();
        }

        private void FBloodBag_ins_Load(object sender, EventArgs e)
        {

        }

        private void AB_plus_CheckedChanged(object sender, EventArgs e)
        {
            type = "AB+";
        }

        private void AB_negative_CheckedChanged(object sender, EventArgs e)
        {
            type = "AB-";

        }

        private void A_plus_CheckedChanged(object sender, EventArgs e)
        {
            type = "A+";

        }

        private void A_negative_CheckedChanged(object sender, EventArgs e)
        {
            type = "A-";

        }

        private void B_plus_CheckedChanged(object sender, EventArgs e)
        {
            type = "B+";

        }

        private void B_negative_CheckedChanged(object sender, EventArgs e)
        {
            type = "B-";

        }

        private void O_plus_CheckedChanged(object sender, EventArgs e)
        {
            type = "O+";

        }

        private void O_neg_CheckedChanged(object sender, EventArgs e)
        {
            type = "O-";

        }
    }
}
