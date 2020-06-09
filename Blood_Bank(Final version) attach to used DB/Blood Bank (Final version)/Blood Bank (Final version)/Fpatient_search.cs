﻿using MySql.Data.MySqlClient;
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
    public partial class Fpatient_search : Form
    {
        public Fpatient_search()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                MySqlConnection cnn;
                connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                string q2 = "select * from patient where blood_type like '" + textBox6.Text + "%'";
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
                string q2 = "select * from patient where hospital_name like '" + textBox6.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(q2, cnn);
                MySqlDataAdapter n = new MySqlDataAdapter(q2, cnn);
                DataTable data = new DataTable();
                n.Fill(data);
                dataGridView1.DataSource = data;
                //MessageBox.Show("Connection Open  !");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fpatient f = new Fpatient();
            f.Show();
            this.Hide();
        }
    }
}