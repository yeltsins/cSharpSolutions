using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle figure = new Rectangle(10, 5);
            Console.WriteLine(figure.Area);
            Console.WriteLine(figure.Perimeter);
            Console.ReadKey();
        }
        
        class Rectangle
        {
            private double side1, side2;
            public double Area { get => AreaCalculator(); }
            public double Perimeter { get => PerimeterCalculator(); }

            public Rectangle(double side1,double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double AreaCalculator()
            {
                return side1 * side2;
            }
            public double PerimeterCalculator()
            {
                return side1 * 2 + side2 * 2;
            }
        }

    }
}
