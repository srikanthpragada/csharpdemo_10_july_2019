using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static class ExMethod
    {
        // Extension method for Person
        public static void Print(this Person p)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
        }
    }

    class ExMethodsDemo
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Abc", Age = 20 };
            p1.Print();
        }
    }
}

