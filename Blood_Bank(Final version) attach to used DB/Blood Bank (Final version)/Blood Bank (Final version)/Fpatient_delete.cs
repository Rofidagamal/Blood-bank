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
    public partial class Fpatient_delete : Form
    {
        public Fpatient_delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("You must compelte all texts");

            }
            else
            {
                Cpatient.delete(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fpatient f = new Fpatient();
            f.Show();
            this.Hide();
        }
    }
}
