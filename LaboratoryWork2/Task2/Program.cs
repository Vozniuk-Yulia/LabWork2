using System;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.92,36.73, 0.60);
            Console.WriteLine("Choose the operation: ");
            Console.WriteLine("1) Convert to USD ");
            Console.WriteLine("2) Convert to EUR ");
            Console.WriteLine("3) Convert to RUB ");
            Console.WriteLine("4) Convert USD to UAH ");
            Console.WriteLine("5) Convert EUR to UAH ");
            Console.WriteLine("6) Convert RUB to UAH ");
            int choice=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter value:");
            double value=Convert.ToDouble(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{value} convert to usd: ");
                    Console.WriteLine(converter.ConvertToUsd(value));
                    break;
                case 2:
                    Console.WriteLine($"{value} convert to eur: ");
                    Console.WriteLine(converter.ConvertToEur(value));
                    break;
                case 3:
                    Console.WriteLine($"{value} convert to rub: ");
                    Console.WriteLine(converter.ConvertToRub(value));
                    break;
                case 4:
                    Console.WriteLine($"USD convert to {value} uah: ");
                    Console.WriteLine(converter.ConvertFromUsdToUah(value));
                    break;
                case 5:
                    Console.WriteLine($"EUR convert to {value} uah: ");
                    Console.WriteLine(converter.ConvertFromEurToUah(value));
                    break;
                case 6:
                    Console.WriteLine($"RUB convert to {value}uah: ");
                    Console.WriteLine(converter.ConvertFromRubToUah(value));
                    break;
                default:
                    Console.WriteLine("Number of operation is not right");
                    break;
            }

        }
    }
}