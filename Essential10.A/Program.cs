using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential10.A
{

    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {            
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            int str=MyClass<int>.FactoryMethod();
            Console.WriteLine(str.GetType().ToString());
            Console.Read();

        }
    }
}
