using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class QueryExpressionDemo
    {
        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            var costlybooks = from b in books
                              where b.Price > 500
                              orderby b.Title
                              select b;

            foreach(var b in costlybooks)
                Console.WriteLine(b.Title);


            var waltherbook= (from b in books
                              where b.Author == "Walther"
                              select new { b.Title, Price = b.Price * 0.70 }
                             ).SingleOrDefault();

            Console.WriteLine(waltherbook.Price);
        }
    }
}
