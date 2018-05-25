using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11._2
{
    interface ICarColl<T>
    {
        void Add(string name, int year);
        void Clear();
        T this[int index] { get; }
        int Count { get; }
    }

    class CarCollection<T> :ICarColl<T> where T:Car,new()
    {
        private T[] array;
        public int Count
        {
            get
            {
                return array.Length;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index>=0&&index<array.Length)
                {
                    return array[index];
                }
                return default(T);
            }
            
        }
        public CarCollection(params T[] cars)
        {
            array = cars;
        }
        public CarCollection()
        {
            array = new T[0];
        }
        public void Clear()
        {
            array = new T[0];
        }
        public void Add(string name,int year)
        {
            T[] tempArr = new T[array.Length];
            array.CopyTo(tempArr,0);
            array = new T[array.Length + 1];
            tempArr.CopyTo(array, 0);
            array[array.Length - 1]=new T();
            array[array.Length-1].Name=name;
            array[array.Length - 1].Year = year;

        }
    }

    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Car(string name,int year)
        {
            Name = name;
            Year = year;
        }
        public Car()
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();
            cars.Add("VOlvo", 1999);
            cars.Add("Mazda", 2001);
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{cars[i].Name}: {cars[i].Year}");
            }
            Console.Read();
        }
    }
}
