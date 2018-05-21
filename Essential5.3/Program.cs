using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(3, 3);
            matrix.Randomize();
            matrix.Show();
            matrix.ChangeDimension(3, 4);
            matrix[3, 4] = 100;
            matrix.Show();
            matrix[4, 4] = 111;
            matrix.Show();
            matrix.Show(2, 2);
            matrix.ChangeDimension(2, 1);
            matrix.Show();
            Console.ReadKey();
        }

        class MyMatrix
        {
            private double[,] matrix;
            private int X;
            private int Y;

            public double this[int x,int y]
            {
                get
                {
                    if (x >= 0 && x <= X && y >= 0 && y <= Y)
                    {
                        return matrix[x-1, y-1];
                    }
                    return 0;
                }
                set
                {
                    if (x>=0&&x<=X&&y>=0&&y<=Y)
                    {
                        matrix[x-1, y-1] = value;
                    }
                    if (x >= 0 && y >= 0 && (y > Y || x > X))
                    {
                        this.ChangeDimension(x, y);                        
                        matrix[x-1, y-1] = value;
                    }
                }
            }

            public MyMatrix(int x,int y)
            {
                matrix = new double[x, y];
                X = x;
                Y = y;
            }
            public void ChangeDimension(int x,int y)
            {
                double[,] temp = new double[X, Y];
                for (int i = 0; i < X; i++)
                {
                    for (int k = 0; k < Y; k++)
                    {
                        temp[i, k] = matrix[i, k];
                    }
                }
                matrix = new double[x, y];
                for (int i = 0; i < Math.Min(x,X); i++)
                {
                    for (int k = 0; k < Math.Min(y, Y); k++)
                    {
                        matrix[i, k] = temp[i, k];
                    }
                }
                X = x;
                Y = y;
            }
            public void Randomize()
            {
                Random random = new Random();
                for (int i = 0; i < X; i++)
                {
                    for (int k = 0; k < Y; k++)
                    {
                        matrix[i, k] = random.Next(0, 100);
                    }
                }
            }
            public void Show()
            {
                Show(X, Y);
            }

            public void Show(int x,int y)
            {

                if (x>0&&y>0&&x<=X&&y<=Y)
                {
                    for (int i = 0; i < x; i++)
                    {
                        for (int k = 0; k < y; k++)
                        {
                            Console.Write($"{matrix[i, k]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("---------------"); 
                }
            }
        }
    }
}
