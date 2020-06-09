using MySql.Data.MySqlClient;
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
    public partial class Fbloodbank_search : Form
    {
        public Fbloodbank_search()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select DISTINCT p.bb_name,name,phone,address from hospital h inner join bb_hospital p on p.h_name=h.name  where p.bb_name like '" + textBox6.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(q2, cnn);
                MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                DataTable data = new DataTable();
                n.Fill(data);
                dataGridView1.DataSource = data;
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select DISTINCT bb_name,rssn ,concat(fname,' ',lname) as 'name',address,phone,salary from recptionest where bb_name like'" + textBox6.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(q2, cnn);
                MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                DataTable data = new DataTable();
                n.Fill(data);
                dataGridView1.DataSource = data;
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select DISTINCT bb_name, bcode,cost,type,assn,donation_type,donation_amount from blood_bag where bb_name like'" + textBox6.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(q2, cnn);
                MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                DataTable data = new DataTable();
                n.Fill(data);
                dataGridView1.DataSource = data;
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select DISTINCT d.* from donor d inner join recptionest r  on rec_ssn=rssn where r.bb_name like'" + textBox6.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(q2, cnn);
                MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                DataTable data = new DataTable();
                n.Fill(data);
                dataGridView1.DataSource = data;
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FBloodBank f = new FBloodBank();
            f.Show();
            this.Hide();
        }
    }
}
