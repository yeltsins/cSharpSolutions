using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential6.A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(100.0,50.5));
            Console.WriteLine(Calculator.Diff(100.0, 50.5));
            Console.WriteLine(Calculator.Div(100.0, 50.5));
            Console.WriteLine(Calculator.Mult(100.0, 50.5));
            Console.ReadKey();
        }

        static class Calculator
        {
            public static double Add(double a,double b)
            {
                return a + b;
            }
            public static double Diff(double a,double b)
            {
                return a - b;
            }
            public static double Div(double a,double b)
            {
                if (b==0)
                {
                    Console.WriteLine("Cant divide by zero");
                    return 0;
                }
                return a / b;
            }
            public static double Mult(double a, double b)
            {
                return a * b;
            }
        }
    }
}
