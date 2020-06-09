using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace boodbank2
{
    public partial class Fhospital_search : Form
    {
        public Fhospital_search()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select DISTINCT * from blood_bank , bb_hospital,hospital where blood_bank.bb_name= bb_hospital.bb_name and hospital.name=h_name and h_name like '" + textBox4.Text + "%'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select DISTINCT * from patient where hospital_name like '" + textBox4.Text + "%'";
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
            FHospital f = new FHospital();
            f.Show();
            this.Hide();
        }
    }
}
