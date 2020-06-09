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
    public partial class Fbloodbank_delete : Form
    {
        public Fbloodbank_delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FBloodBank f = new FBloodBank();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("You must compelte the text");
            }
            else
            {
                CBloodBank.delete(textBox1.Text);
            }

        }
    }
}
