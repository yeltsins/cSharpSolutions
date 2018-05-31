using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17.A
{

    static class Calculator
    {
        public static dynamic Add(dynamic A, dynamic B)
        {
            double valA = 0;
            double valB = 0;
            
            if (double.TryParse(Convert.ToString(B), out valB) &&
                double.TryParse(Convert.ToString(A), out valA))
            {
                return valA + valB;
            }
            return "NaN";
        }
        public static dynamic Sub(dynamic A, dynamic B)
        {
            double valA = 0;
            double valB = 0;

            if (double.TryParse(Convert.ToString(B), out valB) &&
                double.TryParse(Convert.ToString(A), out valA))
            {
                return valA - valB;
            }
            return "NaN";
        }
        public static dynamic Mult(dynamic A, dynamic B)
        {
            double valA = 0;
            double valB = 0;

            if (double.TryParse(Convert.ToString(B), out valB) &&
                double.TryParse(Convert.ToString(A), out valA))
            {
                return valA * valB;
            }
            return "NaN";
        }
        public static dynamic Div(dynamic A, dynamic B)
        {
            double valA=0;
            double valB = 0;
            if (double.TryParse(Convert.ToString(B),out valB)&&
                double.TryParse(Convert.ToString(A), out valA))
            {
                if (valB!=0)
                {
                    return valA / valB;
                }                
            }
            return "NaN";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1.5f,"6,7"));


            Console.Read();
        }
    }
}
