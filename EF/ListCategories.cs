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

            var cats = from c in ctx.Categories
                       where c.Description.Length > 5
                       orderby c.Description
                       select new
                       {
                           Code = c.Code.ToUpper(),
                           Name = c.Description.Substring(0, 5)
                       };


            foreach (var c in cats)
                Console.WriteLine(c.Name);
        }
    }
}
