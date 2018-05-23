using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential9._3
{

    public delegate int SimpleDel();

    public delegate double Anon(SimpleDel[] simple);

    class Program
    {

        static void Main(string[] args)
        {
            SimpleDel simple = () => new Random().Next(0,100);
            SimpleDel[] delegates = { simple, simple, simple };

            Anon anon = (deleg) =>
            {
                double a = 0;
                foreach (var item in deleg)
                {
                    a += item();
                    Console.WriteLine(a);
                }
                return (double)a / deleg.Length;
            };

            Console.WriteLine(anon(delegates));
            Console.Read();

        }
    }
}
