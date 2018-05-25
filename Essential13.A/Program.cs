using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential13.A
{
    class Program
    {

        public static void ThreadMethod()
        {
            Console.WriteLine(Thread.CurrentThread.GetHashCode());
            new Thread(ThreadMethod).Start();
        }

        static void Main(string[] args)
        {
            new Thread(ThreadMethod).Start();
        }
    }
}
