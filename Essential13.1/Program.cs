using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential13._1
{

    class OneFlow
    {
        static object syncobject = new object();
        Random rnd = new Random();
        public int Length { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public OneFlow(int x,int length)
        {
            X = x;
            Y = 0;
            Length = rnd.Next(3, length);
            
        }

        public void Move()
        {

            while (Y<=40)
            {
                lock (syncobject)
                {
                    Console.CursorLeft = X;
                    if (Y - 1 - Length>0)
                    {
                        Console.CursorTop = Y - 1 - Length;
                        Console.WriteLine(' ');
                    }                    
                    for (int i = Y<=24?0:Y-24; i < Length; i++)
                    {
                        if (Y - i <= 0)
                        {
                            break;
                        }
                        
                        Console.CursorLeft = X;
                        Console.CursorTop = Y - i;
                        switch (i)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                        }
                        Console.WriteLine((char)rnd.Next(65, 122));
                    }
                }
                Y++;
                if (Y>=26+Length)
                {
                    Y = 0;
                }
               Thread.Sleep(50);
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //OneFlow[] flows = new OneFlow[70];
            Console.WindowWidth = 75;
            for (int i = 1; i <= 75; i++)
            {
                if (true)
                {
                    OneFlow oneFlow = new OneFlow(i, 15);
                    //flows[i - 1] = oneFlow;
                    new Thread(oneFlow.Move).Start();
                    Thread.Sleep(50);
                }
            }

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (true)
            //    {
            //        OneFlow oneFlow = new OneFlow(i, 8);
            //        //flows[i +34] = oneFlow;
            //        new Thread(oneFlow.Move).Start();
            //        Thread.Sleep(50);
            //    }
            //}

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (true)
            //    {
            //        OneFlow oneFlow = new OneFlow(i, 8);
            //        //flows[i +34] = oneFlow;
            //        new Thread(oneFlow.Move).Start();
            //        Thread.Sleep(50);
            //    }
            //}


            while (true)
            {

            }
        }
    }
}
