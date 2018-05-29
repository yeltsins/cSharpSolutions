using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15._3
{

    struct Price
    {
        public string Name { get; }
        public string Shop { get; }
        public double Tsena { get; }
        public Price(string name,string shop,double price)
        {
            Name = name;
            Shop = shop;
            Tsena = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Shop: {Shop}, Price: {Tsena}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter item name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter item shop");
                string shop = Console.ReadLine();
                double price = 0.0;
                while (price==0.0)
                {
                    Console.WriteLine("Enter item price");
                    try
                    {
                        price=double.Parse(Console.ReadLine());
                        if (price<=0.0)
                        {
                            throw new Exception("Price cant be <= 0");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        Console.WriteLine("Try again");
                        price = 0.0;
                    }
                }
                prices[i] = new Price(name, shop, price);
                
            }
            Console.WriteLine("Enter shop for find items");
            string str;
            while ((str=Console.ReadLine())!="Q")
            {                
                try
                {
                    if (prices.Any(a=>a.Shop==str))
                    {
                        foreach (var item in prices.Where(a => a.Shop == str))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        throw new Exception("No items for this shop");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: "+ex.Message);
                }
            }


        }
    }
}
