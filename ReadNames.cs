using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class ReadNames
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader
                  (@"e:\classroom\msnet\july10\names.txt");

            while (true)
            {
                string name = sr.ReadLine();
                if (name == null)
                    break;

                Console.WriteLine(name.ToUpper());
            }

            sr.Close();
        }
    }
}
