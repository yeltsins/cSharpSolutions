using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential9._2
{
    public delegate double Operator(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Operator sub = (a, b) => a - b;
            Operator sum = (a, b) => a + b;
            Operator div = (a, b) => b == 0 ? 0 : a / b;
            Operator mul = (a, b) => a * b;

            Console.WriteLine(sum(1,2));
            Console.WriteLine(sub(5.5,3.2));
            Console.WriteLine(div(3,0));
            Console.WriteLine(mul(5,4.4));
            Console.Read();
        }
    }
}
