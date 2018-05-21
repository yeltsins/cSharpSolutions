using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1.A
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Apartment = 100,
                City = "Ekaburg",
                Country = "Russia",
                House = 51,
                Index = 640041,
                Street = "Lenina"
            };

            address.PrintAddress();

            Console.ReadKey();
        }

        class Address
        {
            private int index;
            private string country;
            private string city;
            private string street;
            private short house;
            private short apartment;

            public int Index {get => index;set => index = value;}
            public string Country { get => country; set => country=value; }
            public string City { get => city; set => city = value; }
            public string Street { get { return street; } set { street = value; } }
            public short House { get { return house; } set { house = value; } }
            public short Apartment { get { return apartment; } set { apartment = value; } }

            public void PrintAddress()
            {
                foreach (var property in GetType().GetProperties())                
                    Console.WriteLine(property.Name + " is " + property.GetValue(this));               

            }

            
        }

    }
}
