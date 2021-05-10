using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Class_Library
{
    public class AddUser
    {
        public userDto GetAllUsers(string First_name, string Last_name, string Email, string Password)
        {
            userDto user = new userDto();
            DatabaseManager Data_conn = new DatabaseManager();

            using (MySqlConnection conn = new MySqlConnection(Data_conn.Getconn()))
            {
                string query = $"insert into user (Voornaam, Achternaam, Email, Wachtwoord) values( '{First_name}', '{Last_name}', '{Email}', '{Password}')";
                MySqlCommand scmd = new MySqlCommand(query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                MySqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = scmd.ExecuteReader();
                    Trace.WriteLine("Saved");
                    while (sdr.Read())
                    {

                    }
                }
                catch (Exception)
                {
                    Trace.WriteLine("Error");
                    throw;
                }
                return user;
            }
        }
    }
}
