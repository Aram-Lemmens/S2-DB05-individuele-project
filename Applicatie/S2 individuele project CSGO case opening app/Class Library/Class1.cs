using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Class_Library
{
    public class TestDatabaseManager
    {
        string connectionString = "Server=studmysql01.fhict.local;Uid=dbi460546;Database=dbi460546;Pwd=yourPassword;";
        public List<TestDto> GetAllTest()
        {
            List<TestDto> test = new List<TestDto>();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand query = new SqlCommand("select * from test", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        TestDto tst = new TestDto();
                        tst.a = reader.GetInt32(0);
                        tst.b = reader.GetInt32(1);
                        tst.c = reader.GetInt32(2);
                        tst.d = reader.GetInt32(3);

                        test.Add(tst);
                    }
                }
            }

            return test;
        }
    }
}
