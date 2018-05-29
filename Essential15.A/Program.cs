using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15.A
{
    struct Point
    {
        public int X { get; }
        public int Y { get; }
        
        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static Point operator +(Point A, Point B)
        {
            return new Point(A.X + B.X, A.Y + B.Y);
        }
        public static Point operator -(Point A, Point B)
        {
            return new Point(A.X - B.X, A.Y - B.Y);
        }
        public static Point operator *(Point A, Point B)
        {
            return new Point(A.X * B.X, A.Y * B.Y);
        }
        public static Point operator /(Point A, Point B)
        {
            return B.X==0||B.Y==0?throw new Exception("Divided by null exception"):new Point(A.X + B.X, A.Y + B.Y);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(1, 1);
            Point B = new Point(2, 0);
            string command = "";
            while ((command=Console.ReadLine())!="Q")
            {
                try
                {
                    switch (command)
                    {
                        case "+":
                            Console.WriteLine($"X:{(A + B).X}, Y:{(A + B).Y}");
                            break;
                        case "-":
                            Console.WriteLine($"X:{(A - B).X}, Y:{(A + B).Y}");
                            break;
                        case "*":
                            Console.WriteLine($"X:{(A * B).X}, Y:{(A + B).Y}");
                            break;
                        case "/":
                            Console.WriteLine($"X:{(A / B).X}, Y:{(A + B).Y}");
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            


        }
    }
}
