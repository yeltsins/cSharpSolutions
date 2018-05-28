using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential14.A
{

    class Numbers :IEnumerable
    {
        private int[] array;

        public IEnumerable nextNumber
        {
            get
            {
                for (int i = 0; i < array.Length; i++)
                {
                    yield return array[i];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                    yield return array[i];
            }
           
        }


        public Numbers(params int[] numbers)
        {
            array = numbers;
        }
    }

    class Program
    {

        public static IEnumerable GetNumbers(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)                
                    yield return arr[i];
        }


        static void Main(string[] args)
        {

            Numbers numbers = new Numbers(1, 2, 3, 4);

            foreach (var item in numbers.nextNumber)
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetNumbers(1, 2, 3, 4, 5, 6))            
                Console.WriteLine(item);
            

            Console.Read();

        }
    }
}
