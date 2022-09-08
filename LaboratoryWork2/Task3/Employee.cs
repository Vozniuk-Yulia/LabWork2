using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Employee
    {
        private int salaryJun = 10000;
        private int salaryMid = 15000;
        private int salarySen = 23000;
        private string name;
        private string surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
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
        public int SalaryJun(int experience)
        {
            if(experience>3)
            {
                salaryJun += 5000;
            }
            return salaryJun;
        }
        public int SalaryMid(int experience)
        {
            if (experience > 3)
            {
                salaryMid += 5000;
            }
            return salaryMid;
        }
        public int  SalarySen(int experience)
        {
            if (experience > 3)
            {
                salarySen += 5000;
            }
            return salarySen;
        }

    }
}
