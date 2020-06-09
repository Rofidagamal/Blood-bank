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
    class Cdonor
    {
        public static MySqlConnection cnn;
        public static void connection() //this function makes connection with mysql
        {

            string connetionString;

            connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
        }
        public static void insert(String text10,  String text12, String text9, String text8, String text7, String text6, String text5, String text4, String text3, String text2, String text1, String text11) //this function insert new donor
        {
            try
            {
                connection();
                cnn.Open();
                string Sinsert = "insert into donor values ('" + text10 + "' , '" + text12 + "' , '" + text9 + "' , '" + text8 + "' , '" + text7 + "' , '" + text6 + "' , '" + text5 + "' , '" + text4 + "' , '" + text3 + "' , '" + text2 + "' , '" + text1 + "' , '" + text11 + "')"; 
                MySqlCommand cmd = new MySqlCommand(Sinsert, cnn);
                MySqlDataAdapter adabter = new MySqlDataAdapter();
                adabter.InsertCommand = new MySqlCommand(Sinsert, cnn);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                MessageBox.Show("Insert done successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void delete(String s)//this function deletes specific donor
        {
            try { 
            connection();
            cnn.Open();
            string d = "delete from donor where dssn='" + s + "'";
            MySqlCommand cmd = new MySqlCommand(d, cnn);
            MySqlDataAdapter adabter = new MySqlDataAdapter();
            adabter.DeleteCommand = new MySqlCommand(d, cnn);
            adabter.DeleteCommand.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();
            MessageBox.Show("Delete done successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
