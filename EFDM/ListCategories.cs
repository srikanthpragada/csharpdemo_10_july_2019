using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EFDM
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            var ctx = new msdbEntities();
            ctx.Database.Log = Console.WriteLine;

            var cats = ctx.categories.Include("products"); // Eager load

            foreach (var c in cats)
            {
                Console.WriteLine(c.GetType().FullName); // Proxy name 
                Console.WriteLine("{0}  - {1} ", c.catdesc, c.products.Count());
            }
        }
    }
}
