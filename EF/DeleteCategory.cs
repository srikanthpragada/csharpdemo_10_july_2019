using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class DeleteCategory
    {
        static void Main(string[] args)
        {
            using (var ctx = new InventoryContext())
            {
                ctx.Database.Log = Console.WriteLine;
                var cat = ctx.Categories.Find("c1"); // Unchanged
                if (cat == null)
                {
                    Console.WriteLine("Category not found!");
                    return;
                }
                Console.WriteLine(ctx.Entry(cat).State);
                ctx.Categories.Remove(cat);
                Console.WriteLine(ctx.Entry(cat).State);
                ctx.SaveChanges();  // Delete command 
            }
        }
    }
}
