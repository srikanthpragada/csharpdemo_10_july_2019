using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(100);
                Console.Write("{0} ", a[i]);
            }

            Array.Sort(a);
            Console.WriteLine("\nArray After Sorting\n");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }


        }
    }
}
