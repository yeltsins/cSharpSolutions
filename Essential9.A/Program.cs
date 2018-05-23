using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential9.A
{
    class Program
    {

        public delegate double Summ(int a, int b, int c);
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            int c = 7;
            Summ summ = (aa, bb, cc) => (double)(aa + bb + cc)/3;
            Console.WriteLine(summ(a,b,c));
            Console.Read();
        }
    }
}
