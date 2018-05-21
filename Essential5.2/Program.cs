using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10);
            foreach (var item in array.Nechet())
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }

        class MyArray
        {
            private int N;
            private int[] array;
            Random random = new Random();

            public int this[int index]
            {
                get
                {
                    if (index < N && index >= 0)
                    {
                        return array[index];
                    }
                    return 0;
                }
                set
                {
                    if (index<N&&index>=0)
                    {
                        array[index] = value;
                    }
                }
            }

            public MyArray(int n)
            {
                array = new int[n];
                N = n;
                for (int i = 0; i < N; i++)
                {
                    array[i] = random.Next(-100, 100);
                }
            }
            public int MinValue()
            {
                return array.Min();
            }
            public int MaxValue()
            {
                return array.Max();
            }
            public double Seredinka()
            {
                return array.Sum() / (double)array.Length;
            }
            public int Sum()
            {
                return array.Sum();
            }
            public int[] Nechet()
            {
                return array.Where(a => a % 2 == 0).ToArray();
            }
        }
    }
}
