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
    public partial class Fbloodbag_Update_type : Form
    {
        public Fbloodbag_Update_type()
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
                CBloodBag.update2(textBox1.Text, textBox2.Text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FBloodBag f = new FBloodBag();
            f.Show();
            this.Hide();
        }
    }
}
