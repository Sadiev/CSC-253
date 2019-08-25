using System;
/**
* 08/24/2019
* CSC 253
* Dilshod Sadiev
* RetailItem Class
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailItem[] items =  {new RetailItem ( "Jacket", 12, 59.95m ),
                                   new RetailItem ( "Jeans", 40, 34.95m ),
                                   new RetailItem ( "Shirt", 20, 24.95m ) };

            Console.WriteLine("          Description     UnitsOnHand    Price");
            Console.WriteLine(new string('*',50));

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"Item {i}    ");
                Console.Write($"{items[i].Description}".PadRight(16,' '));
                Console.Write($"{items[i].UnitsOnHand}".PadRight(15, ' '));
                Console.WriteLine($"{items[i].Price}");
            }
        }
    }
    class RetailItem
    {
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public decimal Price { get; set; }
        public RetailItem(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }
    }

}
