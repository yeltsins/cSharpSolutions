using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "Not changed";
            myStruct.change = "Not changed";
            StructTaker(myStruct);
            new Program().ClassTaker(myClass);
            Console.WriteLine(myStruct.change);
            Console.WriteLine(myClass.change);

            Console.ReadKey();
        }

        void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }

    }

    class MyClass
    {
        public string change;
    }


    struct MyStruct
    {
        public string change;
    }
}
