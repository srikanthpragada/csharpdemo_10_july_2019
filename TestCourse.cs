using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Course
    {
        // instance variables
        protected String title;
        protected int duration;
        protected int fee;

        // class variable
        private static int taxrate = 15;

        public static int GetTaxRate()
        {
            return taxrate;
        }

        public static int TaxRate
        {
            get
            {
                return taxrate;
            }
        }

        // Constructor 
        public Course(string title, int duration, int fee = 0)
        {
            this.title = title;
            this.duration = duration;
            this.fee = fee;
        }

        // Readonly property 
        public int NetFee  
        {
            get
            {
                return fee + fee * taxrate / 100;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine(this.title);
            Console.WriteLine(this.duration);
            Console.WriteLine(this.fee);
        }

        // Read-write property 
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value > 0)
                    this.duration = value; 
            }
        }
    }

    class OnlineCourse : Course
    {
        private string url;

        public OnlineCourse(string title, string url, int duration, int fee = 0)
               : base(title,duration,fee)
        {
            this.url = url;
        }
        
        // Override Print() of base class 
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.url);
        }
    }


    class TestCourse
    {
        static void Main()
        {
            Course c = new Course("Angular",15,2000);
            c.Print();  // Print() of Course 

            c = new OnlineCourse
                               ("Python", "http://www.xyz.com/2343", 40, 5000);
            c.Print(); // Print() of OnlineCourse
        }
    }
}
