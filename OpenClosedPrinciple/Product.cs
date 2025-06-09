using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ProductType { get; set; }

        public virtual double GetDiscount()
        {
            return 0;
        }

        //public double GetDiscount()
        //{
        //    if (ProductType == 1)
        //    {
        //        return (Price / 100) * 5;
        //    }

        //    if (ProductType == 2)
        //    {
        //        return (Price / 100) * 10;
        //    }
        //    if (ProductType == 3)
        //    {
        //        return (Price / 100) * 15;
        //    }

        //    return 0;
        //}
    }
}
