using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Class_Library
{
    public class TestDatabaseManager
    {
        string connectionString = "Server=studmysql01.fhict.local;Uid=dbi460546;Database=dbi460546;Pwd=Pmn7KpCjdB";
        public List<TestDto> GetAllTest()
        {
            List<TestDto> test = new List<TestDto>();

            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using(MySqlCommand query = new MySqlCommand("select * from test", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        TestDto tst = new TestDto();
                        tst.a = reader.GetString(0);
                        tst.b = reader.GetString(1);
                        tst.c = reader.GetString(2);
                        tst.d = reader.GetString(3);

                        test.Add(tst);
                    }
                }
            }

            return test;
        }
        public List<userDto> GetAllUsers()
        {
            List<userDto> user = new List<userDto>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand query = new MySqlCommand("select * from user", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        userDto u = new userDto();
                        u.id = reader.GetInt32(0);
                        u.Voornaam = reader.GetString(1);
                        u.Achternaam = reader.GetString(2);
                        u.Email = reader.GetString(3);
                        u.Wachtwoord = reader.GetString(4);

                        user.Add(u);
                    }
                }
            }

            return user;
        }
    }
}
