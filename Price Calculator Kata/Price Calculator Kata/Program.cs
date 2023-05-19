using Price_Calculator_Kata;

class Program
{
    static void Main(string[] args)
    {
        Product Book = new Product("The Little Prince", 12345, 20.25);

        Product BookWithTaxAndDiscount = Calculate.AddTaxWithDiscount(Book, 20, 15);
        Console.WriteLine("Sample product: Book with name = “The Little Prince”, UPC=12345, price=$20.25.");
        Console.WriteLine($"Tax amount = ${Calculate.TaxAmount} Discount amount = ${Calculate.DiscountAmount} Price before = ${Book.Price}, price after = ${BookWithTaxAndDiscount.Price} ");
    }
}
