using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductType1 productType1 = new ProductType1();
            productType1.Name = "Product 1";
            productType1.Price = 15000;

            Console.WriteLine(productType1.GetDiscount());

            Console.ReadKey();
        }
    }
}
