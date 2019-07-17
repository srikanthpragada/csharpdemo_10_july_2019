using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Course
    {
        private String title;
        private int duration, fee;
        // Constructor 
        public Course(string t, int d, int f = 0)
        {
            title = t;
            duration = d;
            fee = f;
        }

        public int GetNetFee()
        {
            return fee + fee * 18 / 100;
        }
        public void Print()
        {
            Console.WriteLine(title);
            Console.WriteLine(duration);
            Console.WriteLine(fee);
        }
    }

    class TestCourse
    {
        static void Main()
        {
            Course c = new Course("Angular",15,2000);
            c.Print();
            Console.WriteLine(c.GetNetFee());

            Course c2 = new Course("JavaScript",10);


        }
    }
}
