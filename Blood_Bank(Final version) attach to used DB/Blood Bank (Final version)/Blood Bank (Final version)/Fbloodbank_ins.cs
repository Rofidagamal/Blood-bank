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
    public partial class Fbloodbank_ins : Form
    {
        public Fbloodbank_ins()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {

            if (bb_name.Text == "" || bb_manager_name.Text == "" || phone.Text == "" || address.Text == "" || Hospital.Text == "")
            {
                MessageBox.Show("You must compelte all texts");
            }
            else
            {
                String s1 = bb_name.Text;
                String s2 = phone.Text;
                String s3 = bb_manager_name.Text;
                String s4 = address.Text;
                CBloodBank.insert(s1, s2, s3, s4);
                try
                {
                    string connetionString;
                    MySqlConnection cnn;
                    connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                    cnn = new MySqlConnection(connetionString);
                    cnn.Open();
                    string q2 = "insert into bb_hospital values('" + bb_name.Text + "' , '" + Hospital.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(q2, cnn);
                    MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                    n.InsertCommand = new MySqlCommand(q2, cnn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                string q2 = "insert into bb_hospital values('" + bb_name.Text + "' , '" + Hospital.Text + "')";
                MySqlCommand cmd = new MySqlCommand(q2, cnn);
                MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                n.InsertCommand = new MySqlCommand(q2, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fbloodbank_ins_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FBloodBank f = new FBloodBank();
            f.Show();
            this.Hide();
        }
    }
}
