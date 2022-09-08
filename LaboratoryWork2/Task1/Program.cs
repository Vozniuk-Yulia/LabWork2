using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 33000;
            address.Country = "Ukraine";
            address.City = "Rivne";
            address.Street = "Soborna";
            address.House = 6;
            address.Apartment = 23;
            Console.WriteLine($"Index: {address.Index}, country: {address.Country}, city:{address.City}, street:{address.Street}, house:{address.House}, apartment: {address.Apartment}");

        }
    }
}