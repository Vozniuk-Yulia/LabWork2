using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Yulia", "Voznyuk");
            Console.WriteLine("Choose your position: ");
            Console.WriteLine("1) Junior");
            Console.WriteLine("2) Middle ");
            Console.WriteLine("3) Senior ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter experience ");
            int experience = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}");
                    Console.WriteLine($"Salary: {employee.SalaryJun(experience)}");
                    break;
                case 2:
                    Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}");
                    Console.WriteLine($"Salary:{employee.SalaryMid(experience)}");
                    break;
                case 3:
                    Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}");
                    Console.WriteLine($"Salary: {employee.SalarySen(experience)}");
                    break;
                default:
                    Console.WriteLine("No right");
                    break;
            }
        }
    }
}