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
    public partial class Fmanger : Form
    {
        public Fmanger()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fmanager_update_phone f = new Fmanager_update_phone();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fmanager_update_email f = new Fmanager_update_email();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fmanager_delete f = new Fmanager_delete();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmanger_ins f = new Fmanger_ins();
            f.Show();
            this.Hide();
        }

        private void Fmanger_Load(object sender, EventArgs e)
        {
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Fmanager_search f = new Fmanager_search();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
