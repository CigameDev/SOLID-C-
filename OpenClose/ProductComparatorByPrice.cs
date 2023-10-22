using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class ProductComparatorByPrice : IProductComparator
    {
        public int Compare(Product product1, Product product2)
        {
            return product1.GetPrice() - product2.GetPrice();
        }
    }
}
