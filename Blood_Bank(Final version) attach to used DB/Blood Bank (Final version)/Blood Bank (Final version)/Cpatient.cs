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
    class Cpatient
    {
        public static MySqlConnection cnn;
        public static void connection() //this function makes connection with mysql
        {

            string connetionString;

            connetionString = @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
        }
        public static void insert(String text1, String text2, String text3, String text4, String text5, String text6, String text7, String text8) //this function inserts new patient
        {
            try
            {
                connection();
                cnn.Open();
                string Sinsert = "insert into patient values (  '" + text1 + "' , '" + text2 + "' , '" + text3 + "' , '" + text4 + "' , '" + text5 + "' , '" + text6 + "' , '" + text7 + "' , '" + text8 + "')";
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
        public static void delete(String s)//this function deletes specific patient
        {
            try
            {
                connection();
                cnn.Open();
                string d = "delete from patient where pssn='" + s + "'";
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
        public static void update1(String s1, String s2) //this function updates phone  for specific patient
        {
            try {
                connection();
                cnn.Open();
                string d = "update patient set phone= '" + s2 + "' where pssn='" + s1 + "'";
                MySqlCommand cmd = new MySqlCommand(d, cnn);
                MySqlDataAdapter adabter = new MySqlDataAdapter();
                adabter.UpdateCommand = new MySqlCommand(d, cnn);
                adabter.UpdateCommand.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                MessageBox.Show("Update done successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void update2(String s1, String s2) //this function updates address  for specific  patient
        {
            try
            {
                connection();
                cnn.Open();
                string d = "update patient set address= '" + s2 + "' where pssn='" + s1 + "'";
                MySqlCommand cmd = new MySqlCommand(d, cnn);
                MySqlDataAdapter adabter = new MySqlDataAdapter();
                adabter.UpdateCommand = new MySqlCommand(d, cnn);
                adabter.UpdateCommand.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                MessageBox.Show("Update done successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







    }
}
