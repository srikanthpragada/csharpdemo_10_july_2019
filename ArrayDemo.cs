using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 4, 3, 2 };

            Array.Sort(a);

            foreach(int n in a)
                Console.WriteLine(n);

            Console.WriteLine(Array.BinarySearch(a,3));
            Console.WriteLine(Array.BinarySearch(a,10));
        }
    }
}
