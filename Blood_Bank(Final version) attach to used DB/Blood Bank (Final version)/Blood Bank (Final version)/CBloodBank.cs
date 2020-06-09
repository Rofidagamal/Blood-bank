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
    class CBloodBank
    {
        public static MySqlConnection cnn;
        public static void connection() //this function makes connection with mysql
        {

            string connetionString;

            connetionString =  @"Data Source=localhost;Initial Catalog=blood_bank;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
        }
        public static void insert(String text1, String text2, String text3, String text4)//this function insert new blood bank
        {
            try
            {
                connection();
                cnn.Open();
                string Sinsert = "insert into blood_bank values (  '" + text1 + "' , '" + text3 + "' , '" + text2 + "' , '" + text4 + "')";
                MySqlCommand cmd = new MySqlCommand(Sinsert, cnn);
                MySqlDataAdapter adabter = new MySqlDataAdapter();
                adabter.InsertCommand = new MySqlCommand(Sinsert, cnn);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                MessageBox.Show("Insert done successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void delete(String s)//this function delete specific bloodbank with all relations in other tables
        {
            try
            {
                connection();
                cnn.Open();
                string d = "delete from blood_bank where bb_name='" + s + "'";
                String d2 = "delete from bb_hospital where bb_name='" + s + "'";
                string d3 = "delete from blood_bag where bb_name='" + s + "'";
                string d4 = "delete from recptionest where bb_name='" + s + "'";
                string d5 = "delete from donor where rec_ssn in (select rssn from recptionest where bb_name='" + s + "')";
                MySqlCommand cmd = new MySqlCommand(d, cnn);
                MySqlCommand cmd1 = new MySqlCommand(d2, cnn);
                MySqlCommand cmd2 = new MySqlCommand(d3, cnn);
                MySqlCommand cmd3 = new MySqlCommand(d4, cnn);
                MySqlCommand cmd4 = new MySqlCommand(d5, cnn);
                MySqlDataAdapter adabter = new MySqlDataAdapter();
                adabter.DeleteCommand = new MySqlCommand(d, cnn);
                adabter.DeleteCommand.ExecuteNonQuery();
                adabter.DeleteCommand = new MySqlCommand(d2, cnn);
                adabter.DeleteCommand.ExecuteNonQuery();
                adabter.DeleteCommand = new MySqlCommand(d3, cnn);
                adabter.DeleteCommand.ExecuteNonQuery();
                adabter.DeleteCommand = new MySqlCommand(d4, cnn);
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
        public static void update1(String s1, String s2) //this function updates phone  for specific blood bank
        {
            try { 
            connection();
            cnn.Open();
            string d = "update Blood_bank set phone= '" + s2 + "' where bb_name='" + s1 + "'";
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
        public static void update2(String s1, String s2) //this function updates blood bank manager for specific blood bank
        {
            try { 
            connection();
            cnn.Open();
            string d = "update Blood_bank set bb_manager_name= '" + s2 + "' where bb_name='" + s1 + "'";
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
        public static void update3(String s1, String s2) //this function updates address  for specific blood bank
        {
            try
            {
                connection();
                cnn.Open();
                string d = "update Blood_bank set address= '" + s2 + "' where bb_name='" + s1 + "'";
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
