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
    public partial class Fdonor : Form
    {
        public Fdonor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fdonor_ins f = new Fdonor_ins();
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fdonor_delete f = new Fdonor_delete();
            f.Show();
            this.Hide();


        }



        private void Fdonor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }
    }
}
