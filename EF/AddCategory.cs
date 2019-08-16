using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class AddCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            var cat = new Category { Code = "c1", Description = "Category1" };
            ctx.Categories.Add(cat);
            ctx.SaveChanges();
        }
    }
}
