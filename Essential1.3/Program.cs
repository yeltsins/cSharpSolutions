using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("New book");
            book.SetAuthor("Author");
            book.SetContent("Content");
            book.Show();
            
            Console.ReadKey();
        }

        class Book
        {
            private Dictionary<string,IPrintableField> information;     

            public Book(string title)
            {                
                information = new Dictionary<string, IPrintableField>();
                information["Title"]= new Title(title);
            }
            public void SetTitle(string newTitle)
            {
                information["Title"] = new Title(newTitle);
            }
            public void SetAuthor(string newAuthor)
            {
                information["Author"] = new Author(newAuthor);
            }
            public void SetContent(string newContent)
            {
                information["Content"] = new Content(newContent);
            }
            public void Show()
            {
                foreach (var inform in information)
                {
                    inform.Value.Show();
                }
            }
        }

        public interface IPrintableField
        {
            void Show();
        }

        class Title: IPrintableField
        {
            public string Value { get; }
            public Title (string value)
            {
                Value = value;
            }
            public void Show()
            {
                Console.WriteLine(Value);
            }
        }

        class Author:IPrintableField
        {
            public string Value { get; }
            public Author(string value)
            {
                Value = value;
            }
            public void Show()
            {
                Console.WriteLine(Value);
            }
        }

        class Content:IPrintableField
        {
            public string Value { get; }
            public Content(string value)
            {
                Value = value;
            }
            public void Show()
            {
                Console.WriteLine(Value);
            }
        }


    }
}
