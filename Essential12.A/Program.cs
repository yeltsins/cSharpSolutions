using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential12.A
{
    class EventMaker
    {         
        private Action<string> firstEvent = null;

        public event Action<string> FirstEvent
        {
            add
            {
               firstEvent += value;
            }
            remove
            {
                firstEvent -= value;
            }
        }
        public EventMaker()
        {
        }
        public void EventInvoker()
        {
            firstEvent.Invoke("OMG");
        }
    }

    class Program
    {

        public static void FirstHadler(string s)
        {
            Console.WriteLine("First handler "+s);
        }

        public static void SecondHandler(string s)
        {
            Console.WriteLine("Second handler " + s);
        }

        static void Main(string[] args)
        {
            EventMaker eventMaker = new EventMaker();
            eventMaker.FirstEvent += FirstHadler;
            eventMaker.FirstEvent += SecondHandler;
            eventMaker.EventInvoker();
            Console.Read();
        }
    }
}
