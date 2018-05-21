using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler abstractHandler = AbstractHandler.StartHandler("XML");
            abstractHandler.Create();
            abstractHandler.Open();
            abstractHandler.Change();
            abstractHandler.Save();
            Console.ReadKey();
        }

        abstract class AbstractHandler
        {
            public abstract void Open();
            public abstract void Create();
            public abstract void Change();
            public abstract void Save();
            public static AbstractHandler StartHandler(string type)
            {
                switch (type)
                {
                    case "TXT":
                        return new TXTHandler();
                    case "XML":
                        return new XMLHandler();
                    case "Doc":
                        return new DocHandler();
                    default:
                        Console.WriteLine("HZ this type");
                        return null;
                }
            }
        }

        class XMLHandler : AbstractHandler
        {
            public override void Change()
            {
                Console.WriteLine("Change XML");
                 
            }

            public override void Create()
            {
                Console.WriteLine("Create XML");
                 
            }

            public override void Open()
            {
                Console.WriteLine("Open XML");
                 
            }

            public override void Save()
            {
                Console.WriteLine("Save XML");
                 
            }
        }

        class TXTHandler : AbstractHandler
        {
            public override void Change()
            {
                Console.WriteLine("Change TXT");
                 
            }

            public override void Create()
            {
                Console.WriteLine("Create TXT");
                 
            }

            public override void Open()
            {
                Console.WriteLine("Open TXT");
                 
            }

            public override void Save()
            {
                Console.WriteLine("Save TXT");
                 
            }
        }

        class DocHandler : AbstractHandler
        {
            public override void Change()
            {
                Console.WriteLine("Change Doc");
                 
            }

            public override void Create()
            {
                Console.WriteLine("Create Doc");
                 
            }

            public override void Open()
            {
                Console.WriteLine("Open Doc");
                 
            }

            public override void Save()
            {
                Console.WriteLine("Save Doc");
                 
            }
        }
    }
}
