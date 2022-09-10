using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Employee
    {
        private int salary;
        private int oklad=1000;
        public const double TAX = 0.2;
        public int impost;
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
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }
        public int Impost
        {
            get { return impost; }
            set { impost = value; }
        }
        public int SalaryJun(int experience)
        {
            salary = 10000;

            if(experience>0)
            {
                oklad*=experience;
                salary += oklad;
                impost = (int)(salary * TAX);
                salary -= impost;
            }
            return salary;
        }
        public int SalaryMid(int experience)
        {
            salary = 15000;

            if (experience > 0)
            {
                oklad *= experience;
                salary += oklad;
                impost = (int)(salary * TAX);
                salary -= impost;
            }
            return salary;
        }
        public int  SalarySen(int experience)
        {
            salary = 20000;

            if (experience > 0)
            {
                oklad *= experience;
                salary += oklad;
                impost = (int)(salary * TAX);
                salary -= impost;
            }
            return salary;
        }

    }
}
