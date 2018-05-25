using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11.A
{
    class Program
    {
        class Car
        {
            public string Name { get; set; }
            public int Year { get; set; }

            public Car(string name, int year)
            {
                Name = name;
                Year = year;
            }
            public Car()
            { }
            public override string ToString()
            {
                return $"Model: {Name} Year: {Year}";
            }
        }

        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add("33");
            array.Add("444");
            array.Add(new Car("Car1", 1999));
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
