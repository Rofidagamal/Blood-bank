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
    public partial class Fhospital_ins : Form
    {
        public Fhospital_ins()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phone.Text == "" || address.Text == "")
            {
                MessageBox.Show("You must compelte all texts");
            }
            else
            {
                String s1 = name.Text;
                String s2 = phone.Text;
                String s3 = address.Text;
                ClHospital.insert(s1, s2, s3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fbloodbank_ins f = new Fbloodbank_ins();
            f.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FHospital f = new FHospital();
            f.Show();
            this.Hide();
        }
    }
}
