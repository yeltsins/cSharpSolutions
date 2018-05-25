using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential10._2
{

    interface IListable<T>
    {
        void Add(params T[] newElements);
        void Clear();
        int Count { get; }
        T this[int index] { get;set; }
        bool Contains(T element);
    }

    public class MyList<T> : IListable<T> where T : new()
    {

        private T[] array;

        public int Count { get => array.Length; }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                return new T();
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return true;
                }
            }            
                return false;
        }

        public MyList()
            {
            //array = new T[1];
            }

        public MyList(params T[] newElements)
        {
            array = newElements;
        }

        public void Clear()
        {
            array = new T[0];
        }


        public void Add(params T[] adding)
        {
            T[] temp = new T[array.Length];
            array.CopyTo(temp, 0);
            array = new T[array.Length + adding.Length];
            temp.CopyTo(array, 0);
            adding.CopyTo(array, temp.Length);
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return str;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(1, 2, 3 ,5);
            myList.Add(10,11,12);
            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList[i]);
            //}
            Console.WriteLine(myList);
            Console.WriteLine(myList.Contains(16));
            Console.Read();
        }
    }
}
