using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class SortCustomers
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"e:\classroom\msnet\july10\customers.txt");
            string[] names = sr.ReadToEnd().Split(',');
            Array.Sort(names);
            foreach(string n in names)
                Console.WriteLine(n);

        }
    }
}
