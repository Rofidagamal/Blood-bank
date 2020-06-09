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
    public partial class FBloodBank : Form
    {
        public FBloodBank()
        {
            InitializeComponent();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            Fbloodbank_ins f = new Fbloodbank_ins();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fbloodbank_delete f = new Fbloodbank_delete();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fbloodbank_update_phone f = new Fbloodbank_update_phone();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fbloodbank_update_man_nam f = new Fbloodbank_update_man_nam();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fbloodbank_update_address f = new Fbloodbank_update_address();
            f.Show();
            this.Hide(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void FBloodBank_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       


        private void button4_Click_1(object sender, EventArgs e)
        {
            Fbloodbank_search f = new Fbloodbank_search();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
