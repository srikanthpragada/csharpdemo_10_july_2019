using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class QueryOperatorsDemo
    {
        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            //foreach(var b in books)
            //    if ( b.Price > 500)
            //        Console.WriteLine("{0} - {1}",b.Title,b.Price);

            var costlybooks = books.Where(b => b.Price > 500)
                                   .OrderBy(b => b.Title);

            var avgprice = books.Average(b => b.Price);
            Console.WriteLine("Average price : " + avgprice);

            var avglen = books.Average(b => b.Title.Length);

            foreach (var b in costlybooks)
                Console.WriteLine("{0} - {1}", b.Title, b.Price);

            var maxprice = books.Max(b => b.Price);

            var maxbook = books.Where(b => b.Price == maxprice)
                               .First();

            Console.WriteLine(maxbook == null ? "Nothing Found" : maxbook.Title);
        }
    }
}
