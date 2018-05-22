using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential7.A
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebook = new Notebook[]{
            new Notebook("Super Notebook",null, 123.0)
            ,new Notebook("Super Notebook2","Dell2")
            ,new Notebook(null, -125.0)
            };
            notebook[2].Model = "WTF?";
            notebook[2].Manufacturer = null;
            foreach (var item in notebook)
            {
                item.Show();
            }
            Console.ReadKey();
        }

        struct Notebook
        {
            private string model,manufacturer;
            private double cost;

            public string Model { get => model; set => model=value??"No info"; }
            public string Manufacturer { get => manufacturer; set => manufacturer=value ?? "No info"; }
            public double Cost { get => cost; set => cost=value>=0?value:0; }

            public Notebook(string model,string manufacturer,double cost)
            {
                this.model = model??"No info";
                this.manufacturer = manufacturer??"No info";
                this.cost = cost >= 0 ? cost : 0;
            }
            public Notebook(string model,double cost)
                : this(model,"No info",cost)
            { }
            public Notebook (string model,string manufacturer)
                :this(model,manufacturer,0)
            { }
            public Notebook(string model)
                :this(model,"No info",0)
            { }

            public void Show()
            {
                Console.WriteLine($"Model: {model}, Manufacturer: {manufacturer}, Cost: {cost}");
            }

        }
    }
}
