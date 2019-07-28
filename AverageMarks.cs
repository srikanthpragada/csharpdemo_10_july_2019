using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class AverageMarks
    {
        static void Main(string[] args)
        {
            int total = 0;

            for(int i = 1; i <= 5; )
            {
                Console.Write("Enter marks :");
                try
                {
                    int num = Int32.Parse(Console.ReadLine());
                    total += num;
                    i++;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid Number. Try again!");
                }
            }

            Console.WriteLine("Average : {0}", total / 5);
        }
    }
}
