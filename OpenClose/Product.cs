using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class Product
    {
        private string name;
        private int price;

        public Product(string name,int price) 
        {
            this.name = name;
            this.price = price;
        }
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name;}

        public int GetPrice() { return price;}
        public void SetPrice(int price) {  this.price = price;} 
    }
}
