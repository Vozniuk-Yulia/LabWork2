using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private DateTime date;
        public User(string login, string name,string surname, int age, DateTime date)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = date;
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; } 
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Login: {login}, name: {name}, surname: {surname}, age: {age}, date: {date}");
        }
    }
}
