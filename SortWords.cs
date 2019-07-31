using System;
using System.Collections.Generic;
using System.IO;

namespace CsharpDemo
{
    class SortWords
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader
                 (@"e:\classroom\msnet\july10\text.txt");
            var words = new SortedSet<string>();
            
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                string[] parts = line.Split(' ');
                foreach (string w in parts)
                    words.Add(w);

            }
            sr.Close();

            foreach (string w in words)
                Console.WriteLine(w);
        }
    }
}
