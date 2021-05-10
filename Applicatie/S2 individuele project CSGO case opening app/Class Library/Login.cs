using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Class_Library
{
    public class Login
    {
        public userDto GetAllUsers(string Email, string Password)
        {
            userDto user = new userDto();
            DatabaseManager Data_conn = new DatabaseManager();

            using (MySqlConnection conn = new MySqlConnection(Data_conn.Getconn()))
            {
                string query = "select * from user Where Email = '" + Email + "' and Wachtwoord = '" + Password + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 1)
                {
                    user = null;
                }

                return user;
            }
        }
    }
}
