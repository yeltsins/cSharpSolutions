using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] dictionary = {
                new { Eng = "House", Rus = "Дом" },
                new { Eng = "Tree", Rus = "Дерево" },
                new { Eng = "Window", Rus = "Окно" }
            };

            var dict = new Dictionary<dynamic, dynamic>
            {
                { new {Key="1"}, new {Val="One" } },
                { new {Key="2"}, new {Val="Two" } }
            };

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.Key+ " - "+item.Value.Val);
            }
            Console.Read();

        }
    }
}
