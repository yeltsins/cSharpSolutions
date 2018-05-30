using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17._2
{
    class Program
    {



        class Car
        {
            public string Company { get; }
            public string Model { get; }
            public int Year { get; }
            public string Color { get; }
            public Car(string company,string model,int year,string color)
            {
                Company = company;
                Model = model;
                Year = year;
                Color = color;
            }
            public override string ToString()
            {
                return $"Company: {Company}, Model: {Model}, Year: {Year}, Color: {Color}";
            }
        }

        class Customer
        {
            public string Model { get; }
            public string Name { get; }
            public string Tel { get; }
            public Customer(string model,string name,string tel)
            {
                Model = model;
                Name = name;
                Tel = tel;
            }
            public override string ToString()
            {
                return $"Model: {Model}, Name: {Name}, Tel: {Tel}";
            }
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            { new Car("Mers","S600",1999,"Red"),
            new Car("Mers","S601",1998,"Green")};

            List<Customer> customers = new List<Customer>
            { new Customer("S600","Serg","999"),
            new Customer("S601","Alex","600")};

            var customer = customers.Where(a => a.Name == "Serg")
                .Join(cars, a => a.Model, a => a.Model, (cust, car) => (Model: cust.Model, Color: car.Color, Name: cust.Name, Year: car.Year));
            //var car = cars.Where(a => a.Model == customer.Model).First();
            Console.WriteLine(customer.First());
            //Console.WriteLine(car);
            Console.Read();

        }
    }
}
