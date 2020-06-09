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
    public partial class Fdonor_delete : Form
    {
        public Fdonor_delete()
        {
            InitializeComponent();
        }

        private void Fdonor_delete_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("You must compelte the text");
            }
            else
            {
                Cdonor.delete(textBox1.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fdonor f = new Fdonor();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
