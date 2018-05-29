using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_16._2
{
    class Block
    {
        public double LeftSide { get; }
        public double TopSide { get; }
        public double RightSide { get; }
        public double BottomSide { get; }
        public double Perimeter { get => LeftSide + TopSide + RightSide + BottomSide; }
        public Block(double leftSide, double topSide, double rightSide, double bottomSide)
        {
            LeftSide = leftSide;
            TopSide = topSide;
            RightSide = rightSide;
            BottomSide = bottomSide;
        }

        public override bool Equals(object obj)
        {
            Block block = (Block)obj;
            return block.LeftSide == this.LeftSide &&
                block.TopSide == this.TopSide &&
                block.RightSide == this.RightSide &&
                block.BottomSide == this.BottomSide ? true : false;
        }

        public override string ToString()
        {
            return $"Left: {LeftSide}, Top: {TopSide}, Right: {RightSide}, Bottom: {BottomSide}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Block block1,Block block2)
        {
            return block1.Equals(block2);
        }
        public static bool operator !=(Block block1, Block block2)
        {
            return !block1.Equals(block2);
        }

        public static bool operator <(Block block1, Block block2)
        {
            if (block1.Perimeter<block2.Perimeter)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >(Block block1, Block block2)
        {
            if (block1.Perimeter > block2.Perimeter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(1, 2, 3, 4);
            Block block3 = new Block(1, 2, 3, 5);
            if (block2<block3)
            {
                Console.WriteLine("more");
            }
            else
            {
                Console.WriteLine("less");
            }

            Console.Read();
        }
    }
}
