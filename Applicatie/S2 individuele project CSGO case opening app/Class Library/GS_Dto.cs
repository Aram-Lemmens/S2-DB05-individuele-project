using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class TestDto
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", a, b, c, d);
        }
    }
}
