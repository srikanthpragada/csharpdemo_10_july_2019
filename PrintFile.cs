using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class PrintFile
    {
        static void Main(string[] args)
        {
            Console.Write("Enter filename :");
            string filename = Console.ReadLine();
            int lineno = 1;
            try
            {
                StreamReader sr = new StreamReader(filename);
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;
                    Console.WriteLine("{0}:{1}", lineno, line);
                    lineno++;
                }

                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry! Stopping due to error -->" + ex.Message);
            }

        }
    }
}
