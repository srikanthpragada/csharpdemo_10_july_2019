using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int num = Int32.Parse(Console.ReadLine());

            if(num % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");

        }
    }
}
