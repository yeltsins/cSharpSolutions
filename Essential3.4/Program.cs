using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker documentWorker = DocumentWorker.OpenWorker("exp");
            documentWorker.OpenDocument();
            documentWorker.SaveDocument();
            documentWorker.EditDocument();
            Console.ReadKey();
        }

        class DocumentWorker
        {
            public void OpenDocument()
            {
                Console.WriteLine("Document opened");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("Only in Pro version");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("Only in Expert version");
            }
            public static DocumentWorker OpenWorker(string key)
            {
                switch(key)
                {
                    case "pro":
                        return new ProDocumentWorker();                        
                    case "exp":
                        return new ExpertDocumentWorker();
                    default:
                        return new DocumentWorker();
                }
            }
        }
        class ProDocumentWorker:DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Document edited");
            }
        }
        class ExpertDocumentWorker:ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Document Saved");
            }
        }
    }
}
