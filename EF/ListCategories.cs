using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            // ctx.Database.Log = Console.WriteLine;

            //foreach(Category c in ctx.Categories)
            //    Console.WriteLine(c.Description);

            //var selcats = ctx.Categories
            //              .Where(c => c.Description.Length > 10);

            var top3 = ctx.Categories.Take(3);

            foreach (Category c in top3)
                Console.WriteLine(c.Description);
        }
    }
}
