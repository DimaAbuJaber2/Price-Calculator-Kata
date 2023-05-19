using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public class Product
    {
        public String Name { get; set; }
        public int UPC { get; set; }
        public double Price { get; set; }

        public Product(string name, int upc, double price)
        {
            Name = name;
            UPC = upc;
            Price = Math.Round(price, 2);
        }
    }
}
