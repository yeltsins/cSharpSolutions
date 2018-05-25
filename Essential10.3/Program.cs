using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential10._3
{
    interface IDictionary<K, V>
    {
        void Add(params (K,V)[] keys);
        V this[K key] { get; }
        int Count();
    }

    class MyDictionary<K,V>
    {
        private K[] keyArray;
        private V[] valueArray;

        public V this[K index]
        {
            get
            {
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (keyArray[i].Equals(index))
                    {
                        return valueArray[i];
                    }
                }
                return default(V);
            }
        }

        public void Add(params (K,V)[] keys)
        {
            V[] tempV = new V[valueArray.Length];
            K[] tempK = new K[keyArray.Length];
            keyArray.CopyTo(tempK, 0);
            valueArray.CopyTo(tempV, 0);
            keyArray = new K[keyArray.Length + keys.Length];
            valueArray = new V[valueArray.Length + keys.Length];
            tempK.CopyTo(keyArray,0);
            tempV.CopyTo(valueArray,0);
            for (int i = 0; i < keys.Length; i++)
            {
                keyArray[tempK.Length + i] = keys[i].Item1;
                valueArray[tempV.Length + i] = keys[i].Item2;
            }

        }

        public int Count { get => keyArray.Length; }

        public MyDictionary()
        {
            keyArray = new K[0];
            valueArray = new V[0];
        }

        public MyDictionary(params (K,V)[] par)
        {
            keyArray = new K[par.Length];
            valueArray = new V[par.Length];
            for (int i = 0; i < par.Length; i++)
            {
                keyArray[i] = par[i].Item1;
                valueArray[i] = par[i].Item2;
            }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>(("key1", 1), ("key2", 2));
            myDictionary.Add(("key3",3),("key4",4));
            for (int i = 1; i <= myDictionary.Count; i++)
            {
                Console.WriteLine($"key{i}: {myDictionary["key"+i]}");
            }
            Console.Read();        }
    }
}
