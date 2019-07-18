using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class MyTime
    {
        // Auto-implemented properties
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }
    }

    class TestMyTime
    {
        static void Main(string[] args)
        {
            // Object initialization 
            MyTime t1 = new MyTime { Hours = 10, Mins = 20, Secs = 50 };
        }
    }
}
