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
    public partial class Frecptionest_update_address : Form
    {
        public Frecptionest_update_address()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("You must compelte all texts");

            }
            else
            {
                Creception.update2(textBox5.Text, textBox3.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frecptionest f = new Frecptionest();
            f.Show();
            this.Hide();
        }
    }
}
