using System;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user1", "Yulia", "Voznyuk", 18, new DateTime(2022, 9, 8));
            user.ShowInfo();
        }
    }
}