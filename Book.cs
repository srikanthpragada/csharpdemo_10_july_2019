using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public static Book[] GetBooks()
        {
            return new Book[]
            {
            new Book { Title="C# 4.0", Author="Anders", Price = 550},
            new Book { Title="Oracle 11g",Author="Jason Price", Price=650},
            new Book { Title="ASP.NET 4.0 Unleashed", Author ="Walther", Price = 799},
            new Book { Title="ASP.NET AJAX In Action", Author ="Craig Walls", Price = 500},
            new Book { Title="Introduction To Microsoft ASP.NET AJAX",Author="Dino",Price = 450}
            };
        } // GetBooks()
    } // class
} // Namespace
