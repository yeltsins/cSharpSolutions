using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.Print("Hello!", 2);
            Console.Read();
        }

    }

    static class Printer
    {
        public static void Print(string str, int color)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            switch (color)
            {
                case (int)PrinterColors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("White color");
                    break;
                case (int)PrinterColors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Blue color");
                    break;
                case (int)PrinterColors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Green color");
                    break;
                default:
                    Console.WriteLine("No such color");                    
                    break;
            }
            Console.WriteLine(str);
        }


    }
    public enum PrinterColors
    {
        White = 1,
        Blue = 2,
        Green = 3
    }

}
