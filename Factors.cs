using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int num = Int32.Parse(Console.ReadLine());

            for(int i = 2; i <= num/2; i ++ )
            {
                if ( num % i == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
