using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainStation trainStation = new TrainStation(
            new Train[]{
                new Train("Moscow",2,new DateTime(1999,2,2))
                ,new Train("Moscow",1)
                ,new Train("Piter",3) });

            trainStation.Show();
            trainStation["Moscow"].Show();
            trainStation[3].Show();
            Console.ReadKey();
        }


    }

    struct Train
    {
        public string Destination { get; }
        public int Num { get; }
        public DateTime Time { get; }

        public Train(string destination,int num,DateTime time)
        {
            Destination = destination;
            Num = Math.Abs(num);
            Time = time;
        }
        public Train(string destination, int num)
            : this(destination, num, new DateTime(1, 1, 1)) { }
        public Train(string destination)
            : this(destination, 0, new DateTime(1, 1, 1)) { }
        public Train(int num)
            : this("Unknown destination", 0, new DateTime(1, 1, 1)) { }

        public void Show()
        {
            Console.WriteLine($"Destination: {Destination}, Num: {Num}, Time: {Time}");
        }
    }

    class TrainStation
    {
        private Train[] trains;

        public Train this[int index]
        {
            get
            {
                if (trains.Where(a => a.Num == index).Any())
                {
                    return trains[Array.IndexOf(trains, trains.Where(a => a.Num == index).First())];
                }
                Console.WriteLine("No such train");
                return new Train("");
            }
            
        }

        public Train this[string index]
        {
            get
            {
                if (trains.Where(a=>a.Destination==index).Any())
                {                    
                    return trains[Array.IndexOf(trains, trains.Where(a => a.Destination == index).First())];                    
                }
                Console.WriteLine("No such train");
                return new Train("");
            }

        }

        public TrainStation(Train[] trains)
        {
            this.trains = trains.OrderBy(a => a.Num).ToArray();

        }

        public void Show()
        {
            foreach (var item in trains)
            {
                item.Show();
            }
        }

        
    }


}
