using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public class Calculate
    {
        public static Product AddTax(Product product, double taxRate)
        {
            return new Product
            (
                product.Name,
                product.UPC,
                product.Price + Math.Round(product.Price * (taxRate / 100), 2)
            );

        }
    }
}
