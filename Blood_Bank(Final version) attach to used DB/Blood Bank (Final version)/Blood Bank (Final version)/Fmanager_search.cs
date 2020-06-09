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
    public partial class Fmanager_search : Form
    {
        public Fmanager_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select * from blood_bank where bb_manager_name like '" + textBox1.Text + "%' ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Fmanger f = new Fmanger();
            f.Show();
            this.Hide();
        }
    }
}
