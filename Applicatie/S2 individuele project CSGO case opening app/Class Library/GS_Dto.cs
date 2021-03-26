using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class TestDto
    {
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", a, b, c, d);
        }
    }
    public class userDto
    {
        public int id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", id, Voornaam, Achternaam, Email, Wachtwoord);
        }
    }
}
