
using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(1993,02,02);
            Product produs1 = new Product("Capsuni", 10, Category.Fruit,date, "SC.Capsuna SRL");
            var expiration = produs1.ExpirationDate;
            Console.WriteLine($"Data de expirare  a  produsului este : {expiration}");
        }
    }
}
