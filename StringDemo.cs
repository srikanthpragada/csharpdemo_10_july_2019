using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            String st = "Microsoft Visual Studio.NET";
            Console.WriteLine(".NET present {0}", st.Contains(".NET"));
            Console.WriteLine("Starts with Microsoft{0}", st.StartsWith("Microsoft"));

            Console.WriteLine("First character {0}", st[0]);
            Console.WriteLine("First 5 characters {0}", st.Substring(0, 5));
            Console.WriteLine("Position of Visual {0}", st.IndexOf("Visual"));
            String[] words = st.Split(' ');
            foreach (String w in words)
                Console.WriteLine(w);
        }
    }
}
