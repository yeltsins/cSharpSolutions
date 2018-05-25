using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11._4
{

    class ArrayList
    {
        private object[] array;
        public object this[int index]
        {
            get
            {
                if (index>=0&&index<array.Length)
                {
                    return array[index];
                }
                return null;
            }
        }
        public int Count { get => array.Length; }
        public ArrayList()
        {
            array = new object[0];
        }
        public ArrayList(params object[] arr)
        {
            array = arr;
        }
        public void Clear()
        {
            array = new object[0];
        }
        public void Add(params object[] arr)
        {
            object[] tempArr = new object[array.Length];
            array.CopyTo(tempArr, 0);
            array = new object[array.Length + arr.Length];
            tempArr.CopyTo(array, 0);
            arr.CopyTo(array, tempArr.Length);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(1, "2str", 1.1);
            array.Add("stringa");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]); 
            }
            Console.Read();
        }
    }
}
