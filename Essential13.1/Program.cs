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
        Random rnd = new Random();
        public int Length { get; set; }
        public int X { get; set; }
        int y;
        public int Y { get => y; set => y=value>25?0:value; }
        public char[] Symbols { get; set; }
        public OneFlow(int x,int length)
        {
            X = x;
            Y = 10;
            Length = rnd.Next(0, length);
            Thread.Sleep(5);
            Symbols = new char[25];
            //Symbol=(char)rnd.Next(12352, 12543);

                for (int i = 0; i < 25; i++)
                {
                if (i<Length)
                {
                    Symbols[i] = (char)rnd.Next(65, 122);
                }                    
                else
                {
                    Symbols[i] = ' ';
                }
                //Thread.Sleep(5);
            }

            
            Thread.Sleep(10);
        }


    }

    class Painter
    {
        OneFlow[] flows;
        Random rnd = new Random();

        public Painter()
        {
            flows = new OneFlow[80];
            for (int i = 0; i < 80; i++)
            {
                if (rnd.Next(0,2)==1)
                {
                    flows[i] = new OneFlow(i + 1, 10);
                }
                else
                {
                    flows[i] = new OneFlow(i + 1, 0);
                }
                Thread.Sleep(5);
            }
        }

        public void MoveAllFlows()
        {
            for (int i = 0; i < flows.Length; i++)
            {
                flows[i].Y += 1;
            }
        }


        public void Paint()
        {
            bool drawed = false;
            for (int j = 1; j <= 25; j++)
            {
                for (int i = 0; i < 80; i++)
                {
                    drawed = false;
                    for (int o = 0; o < 25; o++)
                    {
                        if (j == flows[i].Y - o)
                        {
                            switch (o)
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
                            Console.Write(flows[i].Symbols[o]);
                            drawed = true;
                        }

                    }
                    if (!drawed)
                    {
                        Console.Write(' ');
                    }                   

                }
            }
            MoveAllFlows();
        }        

    }


    class Program
    {
        static void Main(string[] args)
        {

            Painter painter = new Painter();
            for (int i = 0; i < 20; i++)
            {
                painter.Paint();
            }
            



            Console.Read();
        }
    }
}
