using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Karuna
{
    public class MyDBhandler
    {
        MySqlConnection conn;
        MySqlDataAdapter da;
        //MysqlDataAdapter da;
        DataTable dt;
        string connStr = "server=localhost;user=root;database=karuna;port=3306;password=123456;";
        public  MyDBhandler()
        {
           // string connStr = "server=localhost;user=root;database=karuna;port=3306;password=123456;";
            conn = new MySqlConnection(connStr);
           
        }

        public DataTable GetTable(String str)
        {

        //    da = new SqlDataAdapter(str, con);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
            dt = new DataTable();
         try
        {
           // Console.WriteLine("Connecting to MySQL...");
            conn.Open();

            //string sql = "SELECT Name, HeadOfState FROM Country WHERE Continent='Oceania'";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();
            da = new MySqlDataAdapter(str, conn);
           
            da.Fill(dt);
           
            //while (rdr.Read())
            //{
            //    Console.WriteLine(rdr[0]+" -- "+rdr[1]);
            //}
            //rdr.Close();
        }
        catch (Exception ex)
        {
            //Console.WriteLine(ex.ToString());
            MessageBox.Show("Error " + ex.ToString());
        }

        conn.Close();
        return dt;

        }

         


        //public int getmax_id(string tablename, string fieldname)
        //{

        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "select isnull(max(convert(bigint," + fieldname + ")),'0') from " + tablename + "";
        //    cmd.Connection = con;
        //    int retval = 0;
        //    retval = Convert.ToInt32 (cmd.ExecuteScalar());

        //    con.Close();

        //    return retval;


        //}

        public string GetValue(String query)
        {

            MySqlCommand cmd = new MySqlCommand();
            conn.Open();

            string str;
            try
            {
                cmd = new MySqlCommand(query, conn);
                str = cmd.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                str = "0";
            }
            conn.Close();

            return str;
        }

        public void Ins_Up_Del(String query)
        {
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                // Perform database operations
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                MessageBox.Show("Error " + ex.ToString());

            }
         
            conn.Close();
        }
       
    }

//    using MySql.Data;
//using MySql.Data.MySqlClient;
//public class Tutorial1
//{
//public static void Main()
//{
//string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
//MySqlConnection conn = new MySqlConnection(connStr);
//try
//{
//Console.WriteLine("Connecting to MySQL...");
//conn.Open();
//// Perform database operations
//}
//catch (Exception ex)
//{
//Console.WriteLine(ex.ToString());
//}
//conn.Close();
//Console.WriteLine("Done.");
//}
//}
}
