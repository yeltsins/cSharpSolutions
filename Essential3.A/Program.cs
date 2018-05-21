using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3.A
{
    class Program
    {
        static void Main(string[] args)
        {
            RedPrint rprinter = new RedPrint();
            rprinter.Print("Hello!");
            Printer printer = rprinter;
            printer.Print("Hello!");
            Console.ReadKey();
        }

        class Printer
        {
            public void Print(string value)
            {
                Console.WriteLine(value);
            }
        }

        class GreenPrint :Printer
        {
            public void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                base.Print(value);
            }
        }

        class RedPrint : Printer
        {
            public void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                base.Print(value);
            }
        }

    }
}
