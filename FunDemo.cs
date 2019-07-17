using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class FunDemo
    {
        static void Main(string[] args)
        {
            int sum = Add(10, 20);
            Console.WriteLine("Sum = {0}",sum);
            int v;
            SetToZero(out v);
            Console.WriteLine(v);
            Console.WriteLine(Multiply());
            Console.WriteLine(Multiply(10));
            Console.WriteLine(Multiply(10,5));
            Console.WriteLine(Multiply(n2:5,n1:7));
            Console.WriteLine(Total(10, 20, 30));
            Console.WriteLine(Total(1, 20, 3,5,66,7));
        }

        static int Total(params int [] nums)
        {
            int sum = 0;

            foreach (int n in nums)
                sum += n;

            return sum;
        }

        static void SetToZero(out int n)
        {
             n = 0;
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Multiply(int n1=10, int n2=10)
        {
            return n1 * n2;
        }
    }
}

