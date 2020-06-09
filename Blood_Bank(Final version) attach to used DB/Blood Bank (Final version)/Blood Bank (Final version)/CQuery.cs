using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace boodbank2
{
    class CQuery
    {
        public static MySqlConnection cnn;
        public static void connection()
        {
            string connetionString;
            connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            //cnn.Open();
        }

        public static void q1()
        {//select concat(fname, ' ', lname ) AS 'name' from donor, blood_bag where assn = dssn and type = 'O+';
            connection();
            cnn.Open();
            String output = " NAME \n";
            String s= "select concat(fname,' ', lname) from donor, blood_bag where assn = dssn and type = 'O+'";
            MySqlCommand com=new MySqlCommand(s,cnn);
            MySqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                output = output + r.GetValue(0) + "\n";
            }
            MessageBox.Show(output);
            com.Dispose();
            cnn.Close();
            

        }
        public static void q2()
        {//select fname, address from recptionest where address like 'it%';
            connection();
            cnn.Open();
            String output = " NAME \n";
            
            String s = "select fname, address from recptionest where address like 'it%'";
            MySqlCommand com = new MySqlCommand(s, cnn);
            MySqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                output = output + r.GetValue(0) +" - "+ r.GetValue(1)+ "\n";
            }
            MessageBox.Show(output);
            com.Dispose();
            cnn.Close();
           

        }
    }
}
