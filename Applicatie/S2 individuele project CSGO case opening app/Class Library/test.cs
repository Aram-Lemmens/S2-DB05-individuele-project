using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            TestDatabaseManager dbMan = new TestDatabaseManager();

            var tests = dbMan.GetAllTest();

            foreach (var test in tests)
            {
                Console.WriteLine(test);
            }
        }    

    }
}
