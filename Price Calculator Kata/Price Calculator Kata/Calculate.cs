using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
     class Calculate
    {
        public static double TaxAmount { get; set; }
        public static double TotalDiscountAmount { get; set; }
        public static double FinalPrice { get; set; }


        public static Product CalculateFinalPrice(Product product, double TaxRate, double UniversalDiscountRate, double UPC_DiscountRate, int UPC_ForDiscount)
        {
            double UniversalDiscountAmount = Math.Round(product.Price * (UniversalDiscountRate / 100), 2);
            double UPC_DiscountAmount = (UPC_ForDiscount == product.UPC) ? Math.Round(product.Price * (UPC_DiscountRate / 100), 2) : 0;

            TaxAmount = Math.Round(product.Price * (TaxRate / 100), 2);
            TotalDiscountAmount = UniversalDiscountAmount + UPC_DiscountAmount;
            FinalPrice = Math.Round(product.Price + TaxAmount - TotalDiscountAmount, 2);

            Report.DiscountedReport(FinalPrice, TotalDiscountAmount);

            return new Product
            (
                product.Name,
                product.UPC,
                FinalPrice
            );

        }



    }
}

