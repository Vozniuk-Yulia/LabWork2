using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public double USD
        {
            get { return usd; }
            set { usd = value; }
        }
        public double EUR
        {
            get { return eur; }
            set { eur = value; }
        }
        public double RUB
        {
            get { return rub; }
            set { rub = value; }
        }
        
       
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd; 
            this.eur = eur;
            this.rub = rub;
        }
        public double ConvertToUsd(double value)
        {
            double res = value / usd;
            return (double)res;
        }
        public double ConvertToEur(double value)
        {
            return value / eur;
        }
        public double ConvertToRub(double value)
        {
            return value / rub;
        }
        public double ConvertFromUsdToUah(double value)
        {
            return value * usd;
        }
        public double ConvertFromEurToUah(double value)
        {
            return value * eur;
        }
        public double ConvertFromRubToUah(double value)
        {
            return value * rub;
        }
    }
}
