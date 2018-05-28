using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    class TestClass
    {
        public string Str { get; set; }
    }

    class Program
    {
        static void TestMeth(TestClass tc)
        {
            TestClass testClass = tc;
            testClass.Str = "111";
        }
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            testClass.Str = "Hello";
            TestMeth(testClass);
            Console.WriteLine(testClass.Str);
            Console.Read();
        }
    }
}
