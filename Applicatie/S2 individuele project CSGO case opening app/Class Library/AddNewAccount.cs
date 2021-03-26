using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Class_Library
{
    public class AddNewAccount
    {
        string connectionString = "Server=studmysql01.fhict.local;Uid=dbi460546;Database=dbi460546;Pwd=Pmn7KpCjdB";
        public userDto GetAllUsers(string Email, string Password)
        {
            userDto user = new userDto();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
