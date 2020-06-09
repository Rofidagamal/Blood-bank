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
    public partial class Fpatient : Form
    {
        public Fpatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fpatient_ins f = new Fpatient_ins();
            f.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fpatient_update_phone f = new Fpatient_update_phone();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fpatient_update_address f = new Fpatient_update_address();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fpatient_delete f = new Fpatient_delete();
            f.Show();
            this.Hide();
        }



        private void button9_Click(object sender, EventArgs e)
        {
            Fpatient_search f = new Fpatient_search();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
