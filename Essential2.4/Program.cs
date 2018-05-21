using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(12345, "Customer", "Provider");
            Console.WriteLine(invoice.Summ("abc", 123, true));
            Console.ReadKey();
        }

        class Invoice
        {
            private readonly int account;
            private readonly string customer, provider;
            private string article;
            private int quantity;

            public string Article { get => article; set => article = value; }
            public int Quantity { get => quantity; set => quantity = value>=1?value:0; }

            public Invoice(int account,string customer,string provider)
            {
                this.account = account;
                this.customer = customer;
                this.provider = provider;            
            }
            public double Summ(string article,int quantity,bool needNDS)
            {
                Quantity = quantity;
                Article = article;
                return needNDS? Quantity*1.15:Quantity;
            }

        }
    }
}
