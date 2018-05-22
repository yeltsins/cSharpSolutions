using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store["Iphone"].Show();
            store["Iphone"]=new Article("Fofone","Restore",444.4);
            store["Fofone"].Show();
            Console.ReadKey();
        }

        class Article
        {
            public string Name { get; set; }
            public string Shop { get; set; }
            public double Cost { get; set; }

            public void Show()
            {
                Console.WriteLine($"Name: {Name}, Shop: {Shop}, Cost: {Cost}");
            }
            public Article(string name,string shop,double cost)
            {
                Cost = cost;
                Shop = shop;
                Name = name;
            }
        }

        class Store
        {
            private Article[] articles;
            public Article this[int index]
            {
                get
                {
                    if (index >= 0 && index < articles.Length)
                    {
                        return articles[index];
                    }
                    Console.WriteLine("Index out of range");
                    return null;
                }
                set
                {
                    if (index >= 0 && index < articles.Length)
                    {
                        articles[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            public Article this[string name]
            {
                get
                {
                    if (articles.Where(a => a.Name == name).Any())
                    {
                        var item = articles.Where(a => a.Name == name).First();
                        return item;
                    }
                    Console.WriteLine("No such article");
                    return null;
                }
                set
                {
                    if (articles.Where(a => a.Name == name).Any())
                    {
                        var item = articles.Where(a => a.Name == name).First();
                        articles[Array.IndexOf(articles, item)] = value;
                    }
                    else
                    {
                        Console.WriteLine("No such article");
                    }
                }
            }

            public Store()
            {
                articles = new Article[]
                {
                    new Article("Lumia", "Microsoft", 123.10)
                    ,new Article("Iphone", "Apple", 223.10)
                    ,new Article("Honor", "Nadroid", 323.10)
                    };

            }
            
        }

            
        }
    
}
