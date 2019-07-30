using System;
using System.IO;

namespace CsharpDemo
{
    class WriteNames
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter
                  (@"e:\classroom\msnet\july10\names.txt",true);

            while(true)
            {
                Console.Write("Enter name [end to stop] :");
                string name = Console.ReadLine();
                if (name == "end")
                    break;

                sw.WriteLine(name);
            }

            sw.Close();
        }
    }
}
