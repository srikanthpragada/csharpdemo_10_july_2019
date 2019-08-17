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
            var cats = ctx.categories;

            foreach (var c in cats)
                Console.WriteLine(c.catdesc);
        }
    }
}
