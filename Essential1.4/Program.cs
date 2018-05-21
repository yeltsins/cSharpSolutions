using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure
            (
                new Point ( 0, 1, "A" ),
                new Point ( 10, 2, "B" ),
                new Point ( 20, 3, "C" ),
                new Point(30, 4, "D"),
                new Point(40, 5, "E")
            );
            figure.PerimeterCalculator();
            Console.WriteLine(figure.Name);
            Console.ReadKey();
        }

        class Point
        {
            private int x,y;
            private string name;
            public int X { get => x; }
            public int Y { get => y; }
            public string Name { get => name; }
            public Point (int x,int y,string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }
        }

        class Figure
        {
            public List<Point> Points { get; }
            public string Name { get; }
            public Figure(Point p1, Point p2, Point p3)
            {
                Points = new List<Point>();
                Points.AddRange(new List<Point> { p1, p2, p3 });
                Name = "";
                foreach (var point in Points)
                    Name += point.Name;

            }
            public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
            {
                Points.Add(p4);
                Name += p4.Name;
            }
            public Figure(Point p1, Point p2, Point p3, Point p4,Point p5) : this(p1, p2, p3,p4)
            {
                Points.Add(p5);
                Name += p5.Name;
            }
            private double LengthSide(Point A,Point B)
            {
                return Math.Sqrt(Math.Pow(A.X-B.X,2)+ Math.Pow(A.Y - B.Y, 2));
            }

            public void PerimeterCalculator()
            {
                double perimeter = 0.0;
                for (int i = 1; i < Points.Count; i++)
                {
                    perimeter += LengthSide(Points[i - 1], Points[i]);
                }
                Console.WriteLine(perimeter);
            }
        }
    }
}
