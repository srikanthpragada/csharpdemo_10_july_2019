using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class SortMarks
    {
        static void Main(string[] args)
        {
            int[] marks = { 67, 88, 45, 63, 49 };

            /*
            for (int i = 0; i < marks.Length ; i++)
            {
                Console.Write("Enter marks : ");
                marks[i] = Int32.Parse(Console.ReadLine());
            }
            */

            Array.Sort(marks);   // sort array 

            for (int i = marks.Length - 1; i >= 0; i--)
                Console.WriteLine(marks[i]);

            //// Print marks 
            //foreach (int v in marks)
            //{
            //    Console.WriteLine(v);
            //}


        }
    }
}
