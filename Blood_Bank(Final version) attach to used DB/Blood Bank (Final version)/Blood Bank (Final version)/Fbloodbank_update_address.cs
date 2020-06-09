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
    public partial class Fbloodbank_update_address : Form
    {
        public Fbloodbank_update_address()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FBloodBank f = new FBloodBank();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("You must compelte all texts");

            }
            else
            {
                CBloodBank.update3(textBox5.Text, textBox3.Text);
            }
        }
    }
}
