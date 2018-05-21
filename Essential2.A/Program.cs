using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2.A
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "User1",
                "Imya",
                "Familiya",
                34);
            User user2 = new User();

            user2.ShowUser();
            Console.ReadKey();
        }
        class User
        {
            private string login;
            public string Login { get => login ?? "Nothing"; set => login = value; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public DateTime CreationDate { get; }

            public User()
            {
                CreationDate = DateTime.Now;
            }
            public User(string login,string firstName,string lastName,int age)
            {
                Login = login;
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                CreationDate = DateTime.Now;

            }
            public void ShowUser()
            {
                foreach (var property in GetType().GetProperties())
                {
                    Console.WriteLine(property.Name+": "+ property.GetValue(this));
                }
            }
        }
    }
}
