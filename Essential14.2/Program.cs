using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential14._2
{

    class MyList<T> : IEnumerable<T>
    {
        private T[] array;

        public int Count { get => array.Length; }

        public T this[uint index]
        {
            get
            {
                if (index < Count)
                {
                    return array[index];
                }
                return default(T);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }


        class ListEnumerator<T> : IEnumerator<T>
        {
            private MyList<T> thisList;

            public ListEnumerator(MyList<T> thisList)
            {
                this.thisList = thisList;
                current = -1;
            }
            private int current;
            public T Current { get => thisList[(uint)current];}

            object IEnumerator.Current { get => thisList[(uint)current]; }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (++current<thisList.Count)
                {
                    return true;
                }
                else
                {
                    Reset();
                    return false;
                }
            }

            public void Reset()
            {
                current = -1;
            }
        }

        public MyList(params T[] arr)
            {
            array = new T[arr.Length];
            array = arr;
            }

        public void Add(params T[] add)
        {
            T[] tempArr = new T[array.Length + add.Length];
            array.CopyTo(tempArr, 0);
            add.CopyTo(tempArr, array.Length);
            array = tempArr;
        }


    }

    class LightList<T>
    {
        private T[] array;

        public int Count { get => array.Length; }

        public T this[uint index]
        {
            get
            {
                if (index < Count)
                {
                    return array[index];
                }
                return default(T);
            }
        }
        public LightList(params T[] arr)
        {
            array = new T[arr.Length];
            array = arr;
        }

        public void Add(params T[] add)
        {
            T[] tempArr = new T[array.Length + add.Length];
            array.CopyTo(tempArr, 0);
            add.CopyTo(tempArr, array.Length);
            array = tempArr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = ++position; i < Count; i++)
            {                
                yield return array[position];
                position++;
            }
            Reset();
        }

        private int position = -1;
        private void Reset()
        {
            position = 3;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> myList = new MyList<int>(1, 2, 3, 4, 5, 6);

            //myList.Add(1, 2, 3);

            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            LightList<int> light = new LightList<int>(1, 2, 3, 4, 5, 6);

            light.Add(1, 2, 3);

            foreach (var item in light)
            {
                Console.WriteLine(item);
            }

            foreach (var item in light)
            {
                Console.WriteLine(item);
            }


            Console.Read();
        }
    }
}
