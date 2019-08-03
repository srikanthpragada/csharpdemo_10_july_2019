using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class AdvDemo
    {
        static void Main(string[] args)
        {
            int n = 10;
            // List<string> names = new List<String>();
            var names = new List<String>();
            var p = new { Name = "Abc", Age = 20 };
            Console.WriteLine(p.Name);
        }
    }
}
