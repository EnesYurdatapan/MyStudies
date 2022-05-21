using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            // GetAll(northwindContext);
            GetProductsByCategory(1);

        }

        private static void GetAll(NorthwindContext northwindContext)
        {
            foreach (var item in northwindContext.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
