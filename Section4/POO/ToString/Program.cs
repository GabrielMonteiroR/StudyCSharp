using ToString.Models;

namespace ToString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product productOne = new Product("PS5", 500.00, 5);
            Console.WriteLine("Start Total value:");
            Console.WriteLine(productOne.TotalValue());
            
            productOne.IncreaseProductQuantity(20);
            Console.WriteLine(productOne.TotalValue());
            
            productOne.DecreaseProductQuantity(4);
            Console.WriteLine(productOne.TotalValue());

            Console.WriteLine("TOSTRING");
            Console.WriteLine(productOne);
            ;

        }
    }
}

