using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace boodbank2
{
    public partial class Fdonor_ins : Form
    {
        String gender="";
        public Fdonor_ins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dssn.Text == "" || gender == "" || fname.Text == "" || lname.Text == "" || age.Text == "" || rssn.Text == "" || weight.Text == "" || height.Text=="" || dateofdonation.Text == "" || pressure1.Text == "" || pressure2.Text == "" || pluserate.Text == "")
                {
                    MessageBox.Show("You must compelte all texts");
                }
                else
                {
                    Cdonor.insert(dssn.Text, gender, fname.Text, lname.Text, age.Text, rssn.Text, weight.Text, height.Text, dateofdonation.Text, tempreture.Text, pressure1.Text + "/" + pressure2.Text, pluserate.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fdonor_ins_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FBloodBag_ins f = new FBloodBag_ins();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fdonor f = new Fdonor();
            f.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }
    }
}
