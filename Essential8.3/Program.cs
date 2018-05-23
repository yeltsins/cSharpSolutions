using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var item in Enum.GetNames(typeof(WorkerPosition)))
            {
                Console.WriteLine($"Give bonus to {item}?");
                Console.WriteLine(Accauntant.AskForBonus((WorkerPosition)Enum.Parse(typeof(WorkerPosition),item), 180));
            }
            
            Console.ReadKey();
        }
    }

    static class Accauntant
    {
        public static bool AskForBonus(WorkerPosition worker,int hours)
        {
            return hours > (int)worker ? true : false;
        }
    }

    enum WorkerPosition
    {
        Director=190,
        Programmer=160,
        TeamLead=180,
        Manager=170
    }
}
