﻿using System.Data.SqlClient;

namespace E_Library
{
    public class Connection
    {
        public static SqlConnection con;
        private static string dbconnect = "Data Source=DESKTOP-VM9TO32;Initial Catalog=E-Library;Integrated Security=True"; //connection string 

        public static void DB()
        {
            try
            {
                con = new SqlConnection(dbconnect);
                con.Open();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
        }
    }
}
//DESKTOP-VJRTO63