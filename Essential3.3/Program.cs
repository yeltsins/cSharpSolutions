using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(1.1,2.2,3.3,60,1980,30,"Shipko");
            ship.PrintInfo();
            Console.ReadKey();
        }

        class Vehicle
        {
            public double XCoord { get; }
            public double YCoord { get; }
            public double Cost { get; }
            public double Speed { get; }
            public int ProductYear { get; }
            public Vehicle()
            {

            }
            public Vehicle(double xCoord, double yCoord,double cost,double speed,int year)
            {
                XCoord = xCoord;
                YCoord = yCoord;
                Cost = cost;
                Speed = speed;
                ProductYear = year;
            }
            public void PrintInfo()
            {
                foreach (var property in GetType().GetProperties())
                {
                    Console.WriteLine($"{property.Name}: {property.GetValue(this)}");
                }
            }
        }

        class Plane:Vehicle
        {
            public double Height { get; }
            public int PassengerCount { get; }
        }

        class Car:Vehicle
        {
            public string Company { get; }
        }
        class Ship:Vehicle
        {
            public int PassengerCount { get; }
            public string Port { get; }

            public Ship(double xCoord, double yCoord, double cost, double speed, int year,int passCount,string port)
                :base(xCoord,yCoord,cost,speed,year)
            {
                PassengerCount = passCount;
                Port = port;
            }
        }

    }
}
