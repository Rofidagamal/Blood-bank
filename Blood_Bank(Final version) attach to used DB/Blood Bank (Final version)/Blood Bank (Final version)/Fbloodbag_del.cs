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
    public partial class Fbloodbag_del : Form
    {
        public Fbloodbag_del()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("You must compelte the text");
            }
            else
            {
                CBloodBag.delete(textBox1.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FBloodBag f = new FBloodBag();
            f.Show();
            this.Hide();
        }

        private void Fbloodbag_del_Load(object sender, EventArgs e)
        {

        }
    }
}
