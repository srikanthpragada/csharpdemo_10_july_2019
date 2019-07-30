using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class SortNames
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader
                 (@"e:\classroom\msnet\july10\names.txt");
            var names = new List<string>();
            var dobs = new List<DateTime>();

            while (true)
            {
                string name = sr.ReadLine();
                if (name == null)
                    break;

                if (name.Trim().Length != 0)
                    names.Add(name);
            }
            sr.Close();
            names.Sort();
            foreach(string n in names)
                Console.WriteLine(n);

        }
    }
}
