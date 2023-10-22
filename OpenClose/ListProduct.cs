using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public  class ListProduct
    {
        private const int MAX_SIZE = 100;
        private int count;
        private Product[] products;

        public ListProduct()
        {
            products = new Product[MAX_SIZE];
        }

        public bool AddProduct(Product product)
        {
            if(this.count < MAX_SIZE)
            {
                products[count] = product;
                this.count++;
                return true;
            }
            return false;
        }

        public void Sort(IProductComparator comparator)
        {
            for(int i =0; i< this.count -1;i++)
            {
                for(int j = i+1; j< this.count;j++)
                {
                    if (comparator.Compare(products[i], products[j]) > 0)
                    {
                        Product temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }    
                }
            }    
        }

        public int GetCount() {  return count; }
        public Product get(int index)
        {
            if(index >=0 && index <this.count)
            {
                return products[index];
            }
            return null;
        }
    }
}
