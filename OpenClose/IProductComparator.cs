using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public interface IProductComparator
    {
        int Compare(Product product1, Product product2);
    }
}
