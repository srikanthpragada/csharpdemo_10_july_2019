using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Point : IComparable<Point>
    {
        // Auto-implemented properties 
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point other)
        {
            if (this.X == other.X)
                if (this.Y == other.Y)
                    return 0;
                else
                    return this.Y - other.Y;
            else
                return this.X - other.X;
        }            

        public override bool Equals(object obj)
        {
            Point other = obj as Point; // Downcasting (base to derived)
            return this.X == other.X && this.Y == other.Y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

    }

    class TestPoint
    {
        static void Main(string[] args)
        {
            String s1 = "Abcd";
            String s2 = "Xyz";

            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.CompareTo(s2));

            Point p1 = new Point { X = 10, Y = 40 };
            Point p2 = new Point { X = 10, Y = 30 };

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.CompareTo(p2));
        }

    }
}

