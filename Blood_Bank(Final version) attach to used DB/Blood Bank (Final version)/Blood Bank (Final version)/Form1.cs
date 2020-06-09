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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FHospital f = new FHospital();
            f.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FBloodBag f = new FBloodBag();
            f.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Fmanger f = new Fmanger();
            f.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FBloodBank f = new FBloodBank();
            f.Show();
            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fpatient f = new Fpatient();
                f.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Fdonor f = new Fdonor();
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frecptionest f = new Frecptionest();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
