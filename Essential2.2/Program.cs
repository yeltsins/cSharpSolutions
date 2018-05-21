using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(1, 10, 100);
            Console.WriteLine(converter.GrToRub(100));
            Console.WriteLine(converter.RubToGr(100));
            Console.ReadKey();
        }
        class Converter
        {
            private double usd, eur, rub;
            public Converter(double usd,double eur,double rub)
            {
                this.usd = usd;
                this.eur = eur;
                this.rub = rub;
            }
            public double GrToUsd(double gr)
            {
                return gr / usd;
            }
            public double GrToEur(double gr)
            {
                return gr / eur;
            }
            public double GrToRub(double gr)
            {
                return gr / rub;
            }
            public double RubToGr(double rub)
            {
                return this.rub * rub;
            }
            public double UsdToGr(double usd)
            {
                return this.usd * usd;
            }
            public double EurToGr(double eur)
            {
                return this.eur * eur;
            }

        }
    }
}
