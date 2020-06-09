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
using Microsoft.VisualBasic;

namespace boodbank2
{
    public partial class FBloodBag : Form
    {
        public string bcode = "";
        public FBloodBag()
        {
            InitializeComponent();
        }


        private void FBloodBag_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FBloodBag_ins f = new FBloodBag_ins();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            Fbloodbag_del f = new Fbloodbag_del();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Fbloodbag_Update_cost f = new Fbloodbag_Update_cost();
            f.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Fbloodbag_Update_type f = new Fbloodbag_Update_type();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fbloodbag_update_bb f = new Fbloodbag_update_bb();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fbloodbag_search f = new Fbloodbag_search();
            f.Show();
            this.Hide();
        }
    }
}
