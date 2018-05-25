using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Essential10._2;


namespace Essential10._4
{

    public static class ArrayGetter
    {
        public static T[] GetArray<T>(this MyList<T> list) where T : new()
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(1, 2, 3, 5);
            myList.Add(10, 11, 12);
            foreach (var item in myList.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
