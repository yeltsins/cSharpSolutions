using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 5,9,6 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine();
                arr = arr.SortByInc();
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                } 
            }
            Console.ReadKey();
        }

    }

    static class ExtMath
    {
        public static int[] SortByInc(this int[] array)
        {
            int[] tempArray = new int[array.Length];
            int[] nr = new int[array.Length];
            //array.CopyTo(tempArray, 0);
            for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i * 2] < array[i * 2 + 1])
                {
                    nr[i] = i * 2;
                    nr[array.Length - 1 - i] = i * 2 + 1;
                }
                else
                {
                    nr[i] = i * 2+1;
                    nr[array.Length - 1 - i] = i * 2;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[nr[i]];
            }
            return tempArray;
        }
    }
}
