using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class UpdateCategory
    {
        static void Main(string[] args)
        {
            using (var ctx = new InventoryContext())
            {
                ctx.Database.Log = Console.WriteLine;
                var cat = ctx.Categories.Find("c2"); // Unchanged
                if (cat == null)
                {
                    Console.WriteLine("Category not found!");
                    return;
                }
                Console.WriteLine(ctx.Entry(cat).State);
                cat.Description = "Category1"; // Modified 
                Console.WriteLine(ctx.Entry(cat).State);
                ctx.SaveChanges();  // Update 
            }
        }
    }
}
