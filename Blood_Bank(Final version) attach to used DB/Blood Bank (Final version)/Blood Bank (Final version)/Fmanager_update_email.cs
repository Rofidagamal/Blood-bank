﻿using System;
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
    public partial class Fmanager_update_email : Form
    {
        public Fmanager_update_email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You must compelte all texts");

            }
            else
            {
                Cmanger.update2(textBox1.Text, textBox2.Text);

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