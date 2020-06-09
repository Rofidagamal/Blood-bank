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
    public partial class Fmanger_ins : Form
    {
        public Fmanger_ins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (phone.Text == "" || email.Text == "" || name.Text == "" || ssn.Text == "")
            {
                MessageBox.Show("You must compelte all texts");
            }
            else
            {
                Cmanger.insert(ssn.Text, name.Text, email.Text, phone.Text);
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
