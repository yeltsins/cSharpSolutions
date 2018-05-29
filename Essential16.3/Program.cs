using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential16._3
{
    class House
    {
        private int windows;
        private Mebel mebel;
        public int Windows { get => windows; set => windows=value; }
        public Mebel Mebel { get => mebel; set => mebel=value; }

        public House(int windows,Mebel mebel)
        {
            this.windows = windows;
            this.mebel = mebel;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public object DeepClone()
        {
            return new House(this.windows, new Mebel(this.mebel.Type, this.mebel.Price));
        }

        public override string ToString()
        {
            return $"Windows: {windows}, Mebel: {mebel}";
        }

    }

    class Mebel
    {
        public string Type { get; set; }
        public double Price { get; set; }
        public Mebel(string type,double price)
        {
            Type = type;
            Price = price;
        }
        public override string ToString()
        {
            return $"Type: {Type}, price: {Price}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(2, new Mebel("stul", 100));
            House houseClone = (House)house.Clone();
            House deepClone = (House)house.DeepClone();
            //houseClone.Mebel.Price = 200;
            deepClone.Mebel.Price = 300;
            Console.WriteLine(house);
            Console.WriteLine(houseClone);
            Console.WriteLine(deepClone);


            Console.Read();
        }
    }
}
