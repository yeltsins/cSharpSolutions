using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15._2
{

    struct Worker
    {
        public string Name { get; }
        public string Position { get; }
        private int year;
        public int Year { get => year; }
        public Worker(string name,string position,string year)
        {
            Name = name;
            Position = position;
            this.year = 0;
            try
            {
                this.year=int.Parse(year);
                if (this.year<=0)
                {
                    throw new Exception("Year must be positive");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Worker ExperienceMoreThan(string experience)
        {
            int exp = 0;
            try
            {
                exp=int.Parse(experience);
                if (exp <= 0)
                {
                    throw new Exception("Experience must be positive");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (DateTime.Now.Year - Year>=exp)
            {
                return this;
            }
            else
            {
                return default(Worker);
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Year: {Year}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];
            for (int i = 0; i < 3; i++)
            {                
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter position");
                string position = Console.ReadLine();
                Console.WriteLine("Enter year");
                string year = Console.ReadLine();
                try
                {
                    workers[i] = new Worker(name, position, year);
                    Console.WriteLine("Successfully created entry");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: "+ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    i--;
                    Console.WriteLine("Enter again");
                }

            }
            while (true)
            {
                Console.WriteLine("Enter experience or Q to exit");
                string str = Console.ReadLine();
                if (str=="Q")
                {
                    break;
                }
                try
                {
                    foreach (var item in workers)
                    {
                        if (!item.ExperienceMoreThan(str).Equals(default(Worker)))
                        {
                            Console.WriteLine(item.ExperienceMoreThan(str));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: "+ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

        }
    }
}
