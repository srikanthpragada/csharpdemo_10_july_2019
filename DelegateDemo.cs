using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class DelegateDemo
    {
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            int[] a = { 10, 22, 35, 57, 69 };

            // int [] en = Array.FindAll(a, IsEven);
            int[] en = Array.FindAll(a, n => n % 2 != 0);
            foreach(int n in en)
               Console.WriteLine(n);
        }
    }
}
