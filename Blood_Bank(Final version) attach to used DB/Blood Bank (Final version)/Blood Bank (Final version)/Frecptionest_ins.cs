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
    public partial class Frecptionest_ins : Form
    {
        public Frecptionest_ins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rssn.Text == "" || fname.Text == "" || lname.Text == "" || address.Text == "" || phone.Text == "" || bb_name.Text == "" || salary.Text == "")
            {
                MessageBox.Show("You must compelte all texts");

            }
            else
            {
                Creception.insert(rssn.Text, fname.Text, lname.Text, address.Text, phone.Text, bb_name.Text, salary.Text);
            }
        }

        private void Frecptionest_ins_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frecptionest f = new Frecptionest();
            f.Show();
            this.Hide();
        }
    }
}
